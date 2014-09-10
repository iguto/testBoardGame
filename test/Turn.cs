using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test {
  class Turn {
    private Board board;

    public Turn() {
      this.board = Board.GetInstance();
    }
    public void execute(){
      Console.WriteLine();
      this.board.Display();
      string rawInput;
      while (true) {
        Console.Write("○の番です｡ 石を置くマスを指定してください｡ (例:1 3): ");
        rawInput = Console.ReadLine();
        if (rawInput.Length != 0) { break; }
      }
      var pos = Position.Parse(rawInput);
      var result = board.PutStone(pos);
      Console.WriteLine(result.ToString());
      
    }
    public Boolean IsGameEnd() { return false; }
  }
}
