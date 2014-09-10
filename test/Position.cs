using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test {
  class Position {
    private int x;
    private int y;
    public int X { get { return this.x; } }
    public int Y { get { return this.y; } }

    public Position(int x, int y) {
      this.x = x;
      this.y = y;
    }

    public void AdjustStonePos() {
      x -= 1;
      y -= 1;
    }

    public static Position Parse(string input) {
      // TODO: fix error when input is not expected format
      var parsed = new Dictionary<string, int>();
      string[] inputs = input.Split(' ');
      int[] parsedInput = inputs.Select(i => int.Parse(i)).ToArray();
      var pos = new Position(parsedInput[1], parsedInput[0]);
      return pos;
    }
  }
}
