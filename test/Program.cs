using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
          Turn turn;
          while (true) {
            turn = new Turn();
            turn.execute();
            if (turn.IsGameEnd()) { break; }
          }
        }
    }
}
