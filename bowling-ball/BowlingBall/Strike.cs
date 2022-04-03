using BowlingBall.Interface;

namespace BowlingBall
{
    public class Strike : Frame, IStrike
    {
        public Strike() : base(10, 0) { }

        public override void AddBonus(Frame framePlusOne, Frame framePlusTwo)
        {
            if (framePlusOne is Strike)
                _frameScore += totalPinsCount + framePlusTwo.FirstRoll();
            else
                _frameScore += framePlusOne.FirstRoll() + framePlusOne.SecondRoll();
        }
    }
}
