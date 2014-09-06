using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
  class Board
  {
    public int Size { get; set; }
    // constructor
    public Board(int size)
    {
      this.Size = size;
      Console.WriteLine("[Board] created");
      Console.WriteLine("  board Size:" + this.Size);
    }
    public void Display() {
      Console.WriteLine("[Board]");
    }
  }
}
