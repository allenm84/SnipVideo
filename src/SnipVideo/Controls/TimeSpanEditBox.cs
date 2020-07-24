using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnipVideo
{
  public partial class TimeSpanEditBox : UserControl
  {
    const int MaxHeight = 21;

    private TimeSpan mValue;
    private bool mCalculateValue = true;
    private bool mReadingValue = false;

    public event EventHandler ValueChanged;

    public TimeSpanEditBox()
    {
      InitializeComponent();
      MinimumSize = Size;
      MaximumSize = new Size(0, MaxHeight);

      var textBoxes = tableLayoutPanel1.Controls
        .OfType<TextBox>();
      foreach (var textBox in textBoxes)
      {
        textBox.TextChanged += textBox_TextChanged;
        textBox.KeyPress += textBox_KeyPress;
      }

      Value = TimeSpan.Zero;
      AdjustBackColor();
    }

    public TimeSpan Value
    {
      get
      {
        if (mCalculateValue)
        {
          string text = string.Concat(tableLayoutPanel1.Controls
            .OfType<Control>()
            .OrderBy(c => c.TabIndex)
            .Select(c => c.Text));

          TimeSpan value;
          if (TimeSpan.TryParse(text, out value))
          {
            mValue = value;
          }

          mCalculateValue = false;
        }
        return mValue;
      }
      set
      {
        ReadValue(value);
      }
    }

    private void NotifyValueChanged()
    {
      if (mReadingValue)
      {
        return;
      }

      var changed = ValueChanged;
      if (changed != null)
      {
        changed(this, EventArgs.Empty);
      }
    }

    private void ReadValue(TimeSpan value)
    {
      mReadingValue = true;

      txtHours.Text = value.Hours.ToString();
      txtMinutes.Text = value.Minutes.ToString();
      txtSeconds.Text = value.Seconds.ToString();
      txtMilliseconds.Text = value.Milliseconds.ToString();

      mReadingValue = false;
    }

    private async void AdjustBackColor()
    {
      await Task.Yield();

      Color color = !Enabled
          ? SystemColors.Control
          : SystemColors.Window;

      var labels = tableLayoutPanel1.Controls.OfType<Label>();
      foreach (var label in labels)
      {
        label.BackColor = color;
      }
      tableLayoutPanel1.BackColor = color;
    }

    protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
    {
      base.SetBoundsCore(x, y, width, MaxHeight, specified);
    }

    protected override void OnEnabledChanged(EventArgs e)
    {
      base.OnEnabledChanged(e);
      AdjustBackColor();
    }

    private void textBox_TextChanged(object sender, EventArgs e)
    {
      mCalculateValue = true;
      NotifyValueChanged();
    }

    private void textBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      char c = e.KeyChar;
      if (char.IsNumber(c) || char.IsControl(c))
      {
        return;
      }
      e.Handled = true;
    }
  }
}
