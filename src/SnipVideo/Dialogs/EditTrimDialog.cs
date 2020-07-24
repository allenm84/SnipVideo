using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnipVideo
{
  public partial class EditTrimDialog : BaseForm
  {
    private readonly string[] mExistingNames;

    public EditTrimDialog(string[] existingNames)
    {
      mExistingNames = existingNames;

      InitializeComponent();
      UpdateCheckBoxText();

      txtStart.ValueChanged += start_ValueChanged;
      txtEnd.ValueChanged += end_ValueChanged;

      txtEnd.DataBindings.Add("Enabled", chkEnd, "Checked");
      chkEnd.CheckedChanged += chkEnd_CheckedChanged;
    }

    public string TrimName
    {
      get { return txtName.Text; }
      set { txtName.Text = value; }
    }

    public bool SpecifyEnd
    {
      get { return chkEnd.Checked; }
      set { chkEnd.Checked = value; }
    }

    public TimeSpan Start
    {
      get { return txtStart.Value; }
      set { txtStart.Value = value; }
    }

    public TimeSpan End
    {
      get { return txtEnd.Value; }
      set { txtEnd.Value = value; }
    }

    private void UpdateCheckBoxText()
    {
      chkEnd.Text = chkEnd.Checked
        ? "End (everything after this will be removed):"
        : "End (go to end of the video):";
    }

    private void UpdateDisplay(Label label, TimeSpanEditBox value)
    {
      double seconds = value.Value.TotalSeconds;
      label.Text = string.Format("{0} second{1}", seconds,
        seconds == 1 ? "" : "s");
    }

    private void start_ValueChanged(object sender, EventArgs e)
    {
      UpdateDisplay(lblStartDisplay, txtStart);
    }

    private void end_ValueChanged(object sender, EventArgs e)
    {
      UpdateDisplay(lblEndDisplay, txtEnd);
    }

    private void chkEnd_CheckedChanged(object sender, EventArgs e)
    {
      UpdateCheckBoxText();
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      if (chkEnd.Checked && (End <= Start))
      {
        cancelClose = true;
        MessageBox.Show(this, "Please specify an end time that is after the start time", "End Time", 
          MessageBoxButtons.OK, MessageBoxIcon.Information);
      }

      if (Array.IndexOf(mExistingNames, txtName.Text) > -1)
      {
        cancelClose = true;
        MessageBox.Show(this, "The name you selected is already being used. Please select another name", "Name in Use",
          MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }
  }
}
