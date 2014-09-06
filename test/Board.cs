using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test {
  class Board {
    public int Size { get; set; }
    private Stone[,] cells;
    // constructor
    public Board(int size) {
      this.Size = size;
      this.cells = new Stone[size, size];

      CreateEmptyCells();

      Console.WriteLine("[Board] created");
      Console.WriteLine("  board Size:" + this.Size);
      Console.WriteLine("  board first cell:" + this.cells[4, 0]);
    }

    private void CreateEmptyCells() {
      for (int i = 0; i < this.Size; i++) {
        for (int j = 0; j < this.Size; j++) {
          this.cells[i, j] = new Stone();
        }
      }
    }

    public void Display() {
      Console.WriteLine("[Board]: display");
      DisplayRowLine();
      for (int i = 0; i < this.Size; i++) {
        Console.Write("｜");
        for (int j = 0; j < this.Size; j++) {
          Console.Write(this.cells[i, j].ConsoleFormat() + "|");
        }
        Console.WriteLine();
        DisplayRowLine();
      }
    }

    private void DisplayRowLine() {
      Console.WriteLine(new String('-', this.Size * 3 + 2));
    }
  }
}
