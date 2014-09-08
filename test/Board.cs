using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test {
  class Board {
    public int Size { get; set; }
    private Stone[][] cells;

    private static Board board = new Board(8);

    // constructor
    private Board(int size) {
      this.Size = size;
      this.cells = new Stone[this.Size][];

      CreateEmptyCells();
      PlaceStonesAtInitialize();
    }

    public static Board GetInstance() {
      return board;
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
      int stonesIndex = 1;
      DisplayColumnNumberLine(this.Size);
      DisplayLineRow();
      foreach (var row in this.cells) {
        DisplayStoneRow(row, stonesIndex);
        stonesIndex += 1;
      }
    }

    private void DisplayColumnNumberLine(int column) {
      Console.Write(" ");
      for (int i = 0; i < column; i++) {
        Console.Write("{0, 4}", i + 1);
      }
      Console.WriteLine();
    }

    private void DisplayStoneRow(Stone[] stones, int index) {
      Console.Write("{0}｜", index);
      foreach (var stone in stones) {
        Console.Write(stone.ConsoleFormat() + "｜");
      }
      Console.WriteLine();
      DisplayLineRow();
    }

    private void DisplayLineRow() {
      Console.Write(" ");
      Console.WriteLine(new String('-', this.Size * 4 + 2));
    }
  }
}
