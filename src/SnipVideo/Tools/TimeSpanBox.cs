using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnipVideo
{
  public class TimeSpanBox
  {
    static TimeSpan sValue;

    private TextBox textBox;
    private TimeSpan lastValue = TimeSpan.Zero;

    public TimeSpan Value
    {
      get
      {
        string text = textBox.Text ?? "";
        if (!TimeSpan.TryParse(text, out sValue))
        {
          sValue = TimeSpan.Zero;
        }
        return sValue;
      }
      set
      {
        textBox.Text = value.GetText();
        FireValueChanged();
      }
    }

    private event EventHandler mValueChanged = (o, e) => { };
    public event EventHandler ValueChanged
    {
      add { mValueChanged += value; }
      remove { mValueChanged -= value; }
    }

    public TimeSpanBox(TextBox textBox)
    {
      this.textBox = textBox;

      ResetText();
      textBox.Validated += textBox_Validated;
      textBox.KeyPress += textBox_KeyPress;
      textBox.Leave += textBox_Leave;
    }

    private void Validate()
    {
      Value = Value;
      FireValueChanged();
    }

    private void ResetText()
    {
      if (string.IsNullOrWhiteSpace(textBox.Text))
      {
        Value = TimeSpan.Zero;
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

    private void textBox_Validated(object sender, EventArgs e)
    {
      Validate();
    }

    private void textBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      char c = e.KeyChar;
      if (char.IsControl(c))
      {
        FireValueChanged();
      }
      else
      {
        var sb = new StringBuilder(textBox.Text);
        int pos = textBox.SelectionStart;
        sb.Insert(pos, c);

        if (TimeSpan.TryParse(sb.ToString(), out sValue))
        {
          FireValueChanged();
        }
        else
        {
          e.Handled = true;
        }
      }
    }

    private void textBox_Leave(object sender, EventArgs e)
    {
      ResetText();
    }
  }
}
