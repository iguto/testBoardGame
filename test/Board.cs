using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test {
  class Board {
    private int size;
    public int Size { get { return this.size; } }

    private Stone[][] cells;

    private static Board board = new Board(8);

    private Board(int size) {
      this.size = size;
      this.cells = new Stone[this.size][];

      CreateEmptyCells();
      PlaceStonesAtInitialize();
    }

    public static Board GetInstance() {
      return board;
    }

    public Boolean PutStone(Position pos, Stone.Type stoneType) {
      pos.AdjustStonePos();
      if (!IsPuttableStone(pos)) { return false; }
      this.cells[pos.Y][pos.X] = new Stone(stoneType);
      return true;
    }

    private Boolean IsPuttableStone(Position pos) {
      var stone = GetStone(pos);
      if (stone.isEmpty()) { return true; }
      return false;
    }

    private Stone GetStone(Position pos) {
      return this.cells[pos.Y][pos.X];
    }

    private void PlaceStonesAtInitialize() {
      this.cells[this.size / 2][this.size / 2] = new Stone(Stone.Type.Black);
      this.cells[this.size / 2 - 1][this.size / 2 - 1] = new Stone(Stone.Type.Black);
      this.cells[this.size / 2 - 1][this.size / 2] = new Stone(Stone.Type.White);
      this.cells[this.size / 2][this.size / 2 - 1] = new Stone(Stone.Type.White);
    }

    private void CreateEmptyCells() {
      for (int i = 0; i < this.cells.Length; i++) {
        Stone[] row = new Stone[this.size];
        for (int j = 0; j < row.Length; j++) {
          row[j] = new Stone(Stone.Type.Empty);
        }
        cells[i] = row;
      }
    }

    public void Display() {
      int stonesIndex = 1;
      DisplayColumnNumberLine(this.size);
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
      Console.WriteLine(new String('-', this.size * 4 + 2));
    }
  }
}
