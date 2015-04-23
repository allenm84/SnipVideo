﻿using System;
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
    private TimeSpanBoxNativeWindow start;
    private TimeSpanBoxNativeWindow end;

    public bool SpecifyEnd
    {
      get { return chkEnd.Checked; }
      set { chkEnd.Checked = value; }
    }

    public TimeSpan Start
    {
      get { return start.Value; }
      set { start.Value = value; }
    }

    public TimeSpan End
    {
      get { return end.Value; }
      set { end.Value = value; }
    }

    public EditTrimDialog()
    {
      InitializeComponent();
      UpdateCheckBoxText();

      start = new TimeSpanBoxNativeWindow(txtStart);
      start.ValueChanged += start_ValueChanged;

      end = new TimeSpanBoxNativeWindow(txtEnd);
      end.ValueChanged += end_ValueChanged;

      txtEnd.DataBindings.Add("Enabled", chkEnd, "Checked");
      chkEnd.CheckedChanged += chkEnd_CheckedChanged;
    }

    private void UpdateCheckBoxText()
    {
      chkEnd.Text = chkEnd.Checked
        ? "End (everything after this will be removed):"
        : "End (go to end of the video):";
    }

    private void UpdateDisplay(Label label, TimeSpanBoxNativeWindow value)
    {
      double seconds = value.Value.TotalSeconds;
      label.Text = string.Format("{0} second{1}", seconds,
        seconds == 1 ? "" : "s");
    }

    private void start_ValueChanged(object sender, EventArgs e)
    {
      UpdateDisplay(lblStartDisplay, start);
    }

    private void end_ValueChanged(object sender, EventArgs e)
    {
      UpdateDisplay(lblEndDisplay, end);
    }

    private void chkEnd_CheckedChanged(object sender, EventArgs e)
    {
      UpdateCheckBoxText();
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      if (chkEnd.Checked && (end.Value <= start.Value))
      {
        cancelClose = true;
        MessageBox.Show(this, "Please specify an end time that is after the start time", "End Time", 
          MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }
  }
}
