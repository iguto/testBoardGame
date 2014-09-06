using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
  class Stone
  {
    public enum Type
    {
      Empty,
      White,
      Black,
    }
    private Type state = Type.Empty;
    
    public Stone() { }

    public Boolean isEmpty() {
      return this.state == Type.Empty;
    }
    public Boolean isWhite()
    {
      return this.state == Type.White;
    }
    public Boolean isBlack()
    {
      return this.state == Type.Black;
    }
  }
}
