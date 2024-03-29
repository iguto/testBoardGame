﻿using System;
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
    public Type state;
    
    public Stone(Type type = Type.Empty) {
      this.state = type;
    }

    public String ConsoleFormat() {
      if (isWhite()) { return "●"; }
      if (isBlack()) { return "○"; }
      return "  ";
    }

    public static List<Type> PlayerStones() {
      return new List<Type>() { Type.Black, Type.White };
    }

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
