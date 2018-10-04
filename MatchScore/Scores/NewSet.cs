using System;
using System.Diagnostics;
using MatchScore.Points;

namespace MatchScore.Scores
{
    class NewSet : IScore
    {
        readonly Stopwatch stopwatch;

        public NewSet(IScore previous, bool youWon, Stopwatch stopwatch)
        {
            this.stopwatch = stopwatch;
            OppSets = youWon ? previous.OppSets : previous.OppSets + 1;
            YouSets = youWon ? previous.YouSets + 1 : previous.YouSets;
            YouServe = !previous.YouServe;
            IsDoubles = previous.IsDoubles;
            IsBestOfFive = previous.IsBestOfFive;
            YouWonThePoint = youWon;
            ElapsedPointTime = stopwatch.Elapsed;
        }

        public int OppGames => 0;

        public int YouGames => 0;

        public int OppSets { get; private set; }

        public int YouSets { get; private set; }

        public bool YouServe { get; private set; }

        public Point OppPoint => Point.Love();

        public Point YouPoint => Point.Love();

        public bool IsDoubles { get; private set; }

        public bool IsBestOfFive { get; private set; }

        public bool YouWonThePoint { get; private set; }

        public TimeSpan ElapsedPointTime { get; private set; }

        public bool IsEndOfMatch => false;

        public IScore SetOppPoint()
        {
            if (YouServe) return new LoveFifteen(this, false, stopwatch);
            return new FifteenLove(this, false, stopwatch);
        }

        public IScore SetYouPoint()
        {
            if (YouServe) return new FifteenLove(this, true, stopwatch);
            return new LoveFifteen(this, true, stopwatch);
        }
    }
}