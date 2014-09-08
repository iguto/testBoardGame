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
      Console.Write("○の番です｡ 石を置くマスを指定してください｡ (例:1 3): ");
      var pos = ParseInput(Console.ReadLine());
      
    }
    public Boolean IsGameEnd() { return false; }

    private Dictionary<string, int> ParseInput(string input) {
      var parsed = new Dictionary<string, int>();
      string[] inputs = input.Split(' ');
      int[] parsedInput = inputs.Select(i => int.Parse(i)).ToArray();
      parsed.Add("y", parsedInput[0]);
      parsed.Add("x", parsedInput[1]);
      return parsed;
    }
  }
}
