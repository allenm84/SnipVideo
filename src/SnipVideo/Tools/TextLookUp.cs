using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnipVideo
{
  public class TextLookUp
  {
    private readonly Dictionary<char, int> mLookUp;

    public TextLookUp(string text)
    {
      mLookUp = text.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
    }

    public int this[char c]
    {
      get
      {
        int count;
        if (!mLookUp.TryGetValue(c, out count))
        {
          count = 0;
          mLookUp[c] = count;
        }
        return count;
      }
    }
  }
}
