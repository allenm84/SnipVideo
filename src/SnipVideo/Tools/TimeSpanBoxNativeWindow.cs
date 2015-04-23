using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnipVideo
{
  public class TimeSpanBoxNativeWindow : NativeWindow
  {
    private Control control;
    private TimeSpan lastValue = TimeSpan.Zero;

    public TimeSpan Value
    {
      get
      {
        string text = control.Text ?? "";
        TimeSpan value;
        if (!TimeSpan.TryParse(text, out value))
        {
          value = TimeSpan.Zero;
        }
        return value;
      }
      set
      {
        control.Text = value.GetText();
        FireValueChanged();
      }
    }

    private event EventHandler mValueChanged = (o, e) => { };
    public event EventHandler ValueChanged
    {
      add { mValueChanged += value; }
      remove { mValueChanged -= value; }
    }

    public TimeSpanBoxNativeWindow(Control control)
    {
      this.control = control;

      if (control.IsHandleCreated)
      {
        AssignHandle(control.Handle);
      }
      else
      {
        control.HandleCreated += control_HandleCreated;
      }

      ResetText();
      control.Validated += control_Validated;
      control.KeyPress += control_KeyPress;
      control.Leave += control_Leave;
    }

    private void Validate()
    {
      Value = Value;
      FireValueChanged();
    }

    private void ResetText()
    {
      if (string.IsNullOrWhiteSpace(control.Text))
      {
        control.Text = "00:00:00";
        FireValueChanged();
      }
    }

    private void FireValueChanged()
    {
      var value = Value;
      if (value != lastValue)
      {
        mValueChanged(this, EventArgs.Empty);
        lastValue = value;
      }
    }

    private void control_HandleCreated(object sender, EventArgs e)
    {
      AssignHandle(control.Handle);
    }

    private void control_Validated(object sender, EventArgs e)
    {
      Validate();
    }

    private void control_KeyPress(object sender, KeyPressEventArgs e)
    {
      bool isNumber = char.IsNumber(e.KeyChar);
      bool isControl = char.IsControl(e.KeyChar);
      bool isDecimal = e.KeyChar == ':' && control.Text.Count(c => c == ':') < 2;
      bool valid = isNumber || isDecimal || isControl;
      if (!valid)
      {
        e.Handled = true;
      }
      else
      {
        FireValueChanged();
      }
    }

    private void control_Leave(object sender, EventArgs e)
    {
      ResetText();
    }
  }
}
