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
          Board board = new Board(5);
          Console.WriteLine("[Program]: board:" + board.Size);
          board.Display();
        }
    }
}
