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
  public partial class BaseForm : Form
  {
    protected bool cancelClose = false;

    public BaseForm()
    {
      InitializeComponent();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (cancelClose)
      {
        e.Cancel = true;
        cancelClose = false;
      }
      base.OnFormClosing(e);
    }
  }
}
