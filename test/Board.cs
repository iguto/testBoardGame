using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test {
  class Board {
    public int Size { get; set; }
    private Stone[][] cells;
    // constructor
    public Board(int size) {
      this.Size = size;
      this.cells = new Stone[this.Size][];

      CreateEmptyCells();
      PlaceStonesAtInitialize();
    }

    private void PlaceStonesAtInitialize() {
      this.cells[this.Size / 2][this.Size / 2] = new Stone(Stone.Type.Black);
      this.cells[this.Size / 2 - 1][this.Size / 2 - 1] = new Stone(Stone.Type.Black);
      this.cells[this.Size / 2 - 1][this.Size / 2] = new Stone(Stone.Type.White);
      this.cells[this.Size / 2][this.Size / 2 - 1] = new Stone(Stone.Type.White);
    }

    private void CreateEmptyCells() {
      for (int i = 0; i < this.cells.Length; i++) {
        Stone[] row = new Stone[this.Size];
        for (int j = 0; j < row.Length; j++) {
          row[j] = new Stone(Stone.Type.Empty);
        }
        cells[i] = row;
      }
    }

    public void Display() {
      DisplayLineRow();
      foreach (var row in this.cells) {
        DisplayStoneRow(row);
      }
    }

    private void DisplayStoneRow(Stone[] stones) {
      Console.Write("｜");
      foreach (var stone in stones) {
        Console.Write(stone.ConsoleFormat() + "｜");
      }
      Console.WriteLine();
      DisplayLineRow();
    }

    private void DisplayLineRow() {
      Console.WriteLine(new String('-', this.Size * 4 + 2));
    }
  }
}
