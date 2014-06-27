using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace peMVVM.Problems.Variables
{
  [StructLayout(LayoutKind.Explicit)]
  public struct type_array
  {
    [FieldOffset(0)]
      public int NumberOfVariablesUsed;
    [FieldOffset(1)]
      public int Int1;
    [FieldOffset(2)]
      public int Int2;
    [FieldOffset(3)]
      public string CommentString;
  }
}
