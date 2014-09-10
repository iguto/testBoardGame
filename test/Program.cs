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
          PlayerQueue pq = new PlayerQueue("プレイヤー1", "プレイヤー2");

          foreach (var player in pq.Players) {
            player.Play();
          }
          foreach (var player in pq.Players) {
            player.Play();
          }
        }
    }
}
