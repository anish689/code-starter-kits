using BowlingBall.Interface;

namespace BowlingBall
{
    public class Open : Frame,IOpen
    {
        public Open(int firstRoll, int secondRoll) : base(firstRoll, secondRoll) { }
    }
}
