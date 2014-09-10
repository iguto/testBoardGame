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
    }

    public Boolean IsGameEnd() { return false; }
  }
}
