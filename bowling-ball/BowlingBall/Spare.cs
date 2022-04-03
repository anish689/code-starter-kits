using BowlingBall.Interface;

namespace BowlingBall
{
    public class Spare : Frame, ISpare
    {
        public Spare(int firstRoll, int secondRoll) : base(firstRoll, secondRoll) { }

        public override void AddBonus(Frame framePlusOne, Frame framePlusTwo)
        {
            _frameScore += framePlusOne.FirstRoll();
        }
    }
}
