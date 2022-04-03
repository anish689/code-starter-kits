using BowlingBall.Factory;
using BowlingBall.Interface;

namespace BowlingBall
{
    public abstract class Frame : IFrame
    {
        protected const int totalPinsCount = 10;
        protected int _pinsFirstRoll;
        protected int _pinsSecondRoll;
        protected int _frameScore;
        protected Frame(int pinsFirstRoll, int pinsSecondRoll)
        {
            _pinsFirstRoll = pinsFirstRoll;
            _pinsSecondRoll = pinsSecondRoll;
        }

        public int Score() { return _pinsFirstRoll + _pinsSecondRoll + _frameScore; }

        public int FirstRoll() { return _pinsFirstRoll; }

        public int SecondRoll() { return _pinsSecondRoll; }

        public static Frame Create(int firstRoll, int secondRoll)
        {
            if (firstRoll == totalPinsCount)
                return (Frame)FrameFactory.CreateStrike();

            if ((firstRoll + secondRoll) == totalPinsCount)
                //return new Spare(firstRoll, secondRoll);
                return (Frame)FrameFactory.CreateSpare(firstRoll, secondRoll);

            return (Frame)FrameFactory.CreateOpen(firstRoll, secondRoll);
        }

        public static Frame Create(int firstRoll, int secondRoll, int thirdRoll)
        {
            return new Final(firstRoll, secondRoll, thirdRoll);
        }

        public virtual void AddBonus(Frame framePlusOne, Frame framePlusTwo) { }
    }
}
