using BowlingBall.Factory;
using BowlingBall.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public class Game
    {
        private readonly List<Frame> _frames = new List<Frame>();
        private const int totalPinsCount = 10;

        public int GetScore()
        {
            Add(new Open(0, 0));
            Add(new Open(0, 0));

            for (int i = 0; i < totalPinsCount; i++)
                _frames[i].AddBonus(_frames[i + 1], _frames[i + 2]);

            int _totalScore = 0;
            _frames.ForEach(frame => _totalScore += frame.Score());
            return _totalScore;
        }

        public void Roll(int firstRoll, int secondRoll)
        {
            if (GameFinished())
                throw new GameOverException();

            Add(Frame.Create(firstRoll, secondRoll));
        }

        public void RollStrike()
        {
            Roll(totalPinsCount, 0);
        }

        private bool GameFinished()
        {
            return _frames.Count.Equals(totalPinsCount);
        }

        private void Add(Frame frame)
        {
            _frames.Add(frame);
        }

        public void RollFinalFrame(int firstRoll, int secondRoll, int thirdRoll)
        {
            Add(Frame.Create(firstRoll, secondRoll, thirdRoll));
        }
    }
}


