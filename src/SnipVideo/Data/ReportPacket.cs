using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnipVideo
{
  public class ReportPacket
  {
    public string Text;
    public bool Increment;

    public static ReportPacket MakeIncrement()
    {
      return new ReportPacket { Increment = true };
    }

    public static ReportPacket MakeText(string text)
    {
      return new ReportPacket { Text = text };
    }
  }
}
