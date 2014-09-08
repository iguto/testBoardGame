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
      var pos = ParseInput(rawInput);
      var result = board.PutStone(pos);
      Console.WriteLine(result.ToString());
      
    }
    public Boolean IsGameEnd() { return false; }

    private Dictionary<string, int> ParseInput(string input) {
      // TODO: fix error when input is not expected format
      var parsed = new Dictionary<string, int>();
      string[] inputs = input.Split(' ');
      int[] parsedInput = inputs.Select(i => int.Parse(i)).ToArray();
      parsed.Add("y", parsedInput[0]);
      parsed.Add("x", parsedInput[1]);
      return parsed;
    }
  }
}
