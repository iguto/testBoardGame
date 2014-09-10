using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test {
  class Player {
    private string name;
    public string Name { get { return this.name; } }
    private int score;
    public int Score { get { return this.score; } }
    public Stone.Type StoneType;

    public Player(string name) {
      this.name = name;
      this.score = 0;
    }

    public void setStoneType(Stone.Type stoneType) {
      this.StoneType = stoneType;
    }

    public void Play() {
      var board = Board.GetInstance();
      string rawInput;
      Boolean result = false;

      Console.WriteLine();
      board.Display();

      while (!result) {
        Console.Write("{0}({1})の番です｡ 石を置くマスを指定してください｡ (例:1 3): ",
          this.name, this.StoneType);
        rawInput = Console.ReadLine();
        if (rawInput.Length == 0) { continue; }
        var pos = Position.Parse(rawInput);
        result = board.PutStone(pos, this.StoneType);
      }
    }
  }
}
