using BowlingBall.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Factory
{
    internal class FrameFactory
    {
        public static ISpare CreateSpare(int firstRoll, int secondRoll)
        {
            return new Spare(firstRoll, secondRoll);
        }

        public static IStrike CreateStrike()
        {
            return new Strike();
        }

        public static IOpen CreateOpen(int firstRoll, int secondRoll)
        {
            return new Open(firstRoll, secondRoll);
        }

        public static IFinal CreateFinal(int firstRoll, int secondRoll , int thirdRoll)
        {
            return new Final(firstRoll, secondRoll, thirdRoll);
        }
    }
}
