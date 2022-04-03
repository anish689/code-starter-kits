using BowlingBall.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Factory
{
     interface IFrameFactory
    {
          IStrike CreateStrike();
         ISpare CreateSpare(int firstRoll, int secondRoll);
    }
}
