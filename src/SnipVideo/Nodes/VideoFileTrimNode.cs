using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnipVideo
{
  public class VideoFileTrimNode : TreeNode
  {
    public TimeSpan Start { get; set; }
    public TimeSpan End { get; set; }
    public bool SpecifyEnd { get; set; }

    public VideoFileTrimNode()
    {
      UpdateText();
    }

    public void UpdateText()
    {
      string start = Start.GetText();
      string end = End.GetText();

      base.Text = string.Format("Trim from '{0}' to '{1}'",
        start, SpecifyEnd ? end : "end");
    }
  }
}
