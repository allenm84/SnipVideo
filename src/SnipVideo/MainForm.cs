using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnipVideo.Properties;

namespace SnipVideo
{
  public partial class MainForm : BaseForm
  {
    public MainForm()
    {
      InitializeComponent();
      openFileDialog.Filter = Resources.VideoFiles;
      UpdateButtonsAsync();
      SetIsWorkingAsync(false);
    }

    private async void SetIsWorkingAsync(bool working)
    {
      await Task.Yield();
      SetIsWorking(working);
    }

    private void SetIsWorking(bool working)
    {
      Cursor = working ? Cursors.WaitCursor : Cursors.Default;
      progStatus.Visible = working;
      tableLayoutPanel1.Enabled = !working;
    }

    private void AcceptPacket(ReportPacket packet)
    {
      if (packet.Increment)
      {
        progStatus.Increment(1);
      }
      else
      {
        progStatus.Text = packet.Text;
      }
    }

    private void AddFiles(params string[] files)
    {
      treeFiles.BeginUpdate();

      foreach (var file in files)
      {
        AddFile(file);
      }

      treeFiles.EndUpdate();
      UpdateButtonsAsync();
    }

    private void AddFile(string file)
    {
      string ext = string.Format("*{0};", Path.GetExtension(file));
      if (!openFileDialog.Filter.Contains(ext))
      {
        return;
      }

      if (Exists(file))
      {
        return;
      }

      treeFiles.Nodes.Add(new VideoFileNode(file));
    }

    private bool Exists(string file)
    {
      return treeFiles.Nodes
        .OfType<VideoFileNode>()
        .Any(f => f.Matches(file));
    }

    private async void UpdateButtonsAsync()
    {
      await Task.Yield();
      UpdateButtons();
    }

    private void UpdateButtons()
    {
      var file = treeFiles.SelectedNode as VideoFileNode;
      var trim = treeFiles.SelectedNode as VideoFileTrimNode;

      bool fileSelected = (file != null);
      bool trimSelected = (trim != null);

      btnRemoveVideo.Enabled = fileSelected;
      btnClearVideos.Enabled = treeFiles.Nodes.Count > 0;

      tpnlTrimButtons.Enabled = (fileSelected || trimSelected);
      btnEditTrim.Enabled = trimSelected;
      btnRemoveTrim.Enabled = trimSelected;

      if (trimSelected)
      {
        file = trim.Parent as VideoFileNode;
      }
      btnClearTrims.Enabled = (file != null) && (file.Nodes.Count > 0);
    }

    private void DeleteSelectedNode()
    {
      var node = treeFiles.SelectedNode;
      if (node != null)
      {
        node.Remove();
        UpdateButtonsAsync();
      }
    }

    private void ApplyTrim(VideoFileTrimNode trim, EditTrimDialog dlg)
    {
      trim.Start = dlg.Start;
      trim.End = dlg.End;
      trim.SpecifyEnd = dlg.SpecifyEnd;
      trim.UpdateText();
    }

    private IEnumerable<string> GenerateArguments()
    {
      int n;
      foreach (var file in treeFiles.Nodes.OfType<VideoFileNode>())
      {
        n = 1;
        foreach (var trim in file.Nodes.OfType<VideoFileTrimNode>())
        {
          var sb = new StringBuilder();
          sb.AppendFormat("-i \"{0}\"", file.Filepath);
          sb.AppendFormat(" -ss {0}", trim.Start.GetText());
          if (trim.SpecifyEnd)
          {
            var duration = trim.End - trim.Start;
            sb.AppendFormat(" -t {0}", duration.GetText());
          }
          sb.Append(" -async 1");
          sb.AppendFormat(" \"{0}\"", file.GenerateTrimPath(n++));
          yield return sb.ToString();
        }
      }
    }

    private async void RunSnipVideo(string[] args, IProgress<ReportPacket> progress)
    {
      SetIsWorking(true);
      {
        await Task.Run(() =>
        {
          string filepath = Path.GetTempFileName();
          try
          {
            File.WriteAllBytes(filepath, Resources.ffmpeg);
            foreach (var arg in args)
            {
              string text = arg.Split(' ').Last();
              progress.Report(ReportPacket.MakeText(text));
              var info = new ProcessStartInfo(filepath, arg);
              info.UseShellExecute = false;
              info.CreateNoWindow = true;
              Process.Start(info).WaitForExit();
              progress.Report(ReportPacket.MakeIncrement());
            }
          }
          finally
          {
            File.Delete(filepath);
          }
        });
      }
      SetIsWorking(false);
    }

    private void treeFiles_DragEnter(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent(DataFormats.FileDrop))
      {
        e.Effect = DragDropEffects.Copy;
      }
      else
      {
        e.Effect = DragDropEffects.None;
      }
    }

    private void treeFiles_DragDrop(object sender, DragEventArgs e)
    {
      var data = e.Data.GetData(DataFormats.FileDrop) as string[];
      if (data != null)
      {
        AddFiles(data);
      }
    }

    private void treeFiles_AfterSelect(object sender, TreeViewEventArgs e)
    {
      UpdateButtonsAsync();
    }

    private void btnAddVideo_Click(object sender, EventArgs e)
    {
      if (openFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
      {
        AddFiles(openFileDialog.FileNames);
      }
    }

    private void btnRemoveVideo_Click(object sender, EventArgs e)
    {
      DeleteSelectedNode();
    }

    private void btnClearVideos_Click(object sender, EventArgs e)
    {
      treeFiles.Nodes.Clear();
    }

    private void btnAddTrim_Click(object sender, EventArgs e)
    {
      var node = treeFiles.SelectedNode;
      if (node == null)
      {
        return;
      }

      if (node is VideoFileTrimNode)
      {
        node = node.Parent;
      }

      var file = node as VideoFileNode;
      if (file == null)
      {
        return;
      }

      using (var dlg = new EditTrimDialog())
      {
        dlg.Text = "Add Trim";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          var trim = new VideoFileTrimNode();
          ApplyTrim(trim, dlg);
          file.Nodes.Add(trim);
          file.Expand();
        }
      }
    }

    private void btnEditTrim_Click(object sender, EventArgs e)
    {
      var trim = treeFiles.SelectedNode as VideoFileTrimNode;
      if (trim == null)
      {
        return;
      }

      using (var dlg = new EditTrimDialog())
      {
        dlg.Text = "Edit Trim";
        dlg.Start = trim.Start;
        dlg.End = trim.End;
        dlg.SpecifyEnd = trim.SpecifyEnd;

        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          ApplyTrim(trim, dlg);
        }
      }
    }

    private void btnRemoveTrim_Click(object sender, EventArgs e)
    {
      DeleteSelectedNode();
    }

    private void btnClearTrims_Click(object sender, EventArgs e)
    {
      var node = treeFiles.SelectedNode;
      if (node is VideoFileTrimNode)
      {
        node = node.Parent;
      }

      var file = node as VideoFileNode;
      if (file == null)
      {
        return;
      }

      file.Nodes.Clear();
    }

    private void treeFiles_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete)
      {
        DeleteSelectedNode();
      }
    }

    private void btnRun_Click(object sender, EventArgs e)
    {
      var args = GenerateArguments().ToArray();
      progStatus.Value = 0;
      progStatus.Maximum = args.Length;
      RunSnipVideo(args, new Progress<ReportPacket>(AcceptPacket));
    }
  }
}
