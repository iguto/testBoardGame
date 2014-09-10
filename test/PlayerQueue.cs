using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test {
  class PlayerQueue {
    private List<Player> players = new List<Player>();
    public List<Player> Players { get { return this.players; } }

    public PlayerQueue(params string[] playerNames) {
      List<Stone.Type> types = Stone.PlayerStones();
      int index = 0;
      foreach (var name in playerNames) {
        var player = new Player(name);
        player.setStoneType(types[index]);
        this.players.Add(player);
        index++;
      }
    }
  }
}
