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
    private int[,] cells;
    // constructor
    public Board(int size)
    {
      this.Size = size;
      this.cells = new int[size, size];
      Console.WriteLine("[Board] created");
      Console.WriteLine("  board Size:" + this.Size);
      Console.WriteLine("  board cells:" + this.cells.Length);
      Console.WriteLine("  board first cell:" + this.cells[4,0]);
    }
    public void Display() {
      Console.WriteLine("[Board]: display");
    }
  }
}
