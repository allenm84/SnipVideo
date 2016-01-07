using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnipVideo
{
  public class VideoFileNode : TreeNode
  {
    private readonly FileInfo file;
    public string Filepath { get { return file.FullName; } }

    public VideoFileNode(string filepath)
    {
      file = new FileInfo(filepath);
      Text = file.Name;
    }

    private string ToSafeFileName(string text)
    {
      foreach (var c in Path.GetInvalidFileNameChars().Select(c=>c.ToString()))
      {
        text = text.Replace(c, string.Empty);
      }

      return text;
    }

    public bool Matches(string filepath)
    {
      return file.IsSameAs(new FileInfo(filepath));
    }

    public string GenerateTrimPath(int number, VideoFileTrimNode trim)
    {
      string name = Path.GetFileNameWithoutExtension(file.FullName);
      string ext = file.Extension;
      string dir = file.Directory.FullName;

      string trimName = ToSafeFileName(trim.TrimName);
      if (string.IsNullOrWhiteSpace(trimName))
      {
        return Path.Combine(dir, string.Format("{0}_trim{1:00}{2}", name, number, ext));
      }
      else
      {
        return Path.Combine(dir, string.Format("{0}_{1}{2}", name, trimName, ext));
      }
    }
  }
}
