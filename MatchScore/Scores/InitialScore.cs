using System;
using System.Diagnostics;
using MatchScore.Points;

namespace MatchScore.Scores
{
    class InitialScore : IScore
    {
        readonly Stopwatch stopwatch;

        internal InitialScore(bool isDoubles, bool isBestOfFive, bool youServe, Stopwatch stopwatch)
        {
            YouServe = youServe;
            IsDoubles = isDoubles;
            ElapsedPointTime = stopwatch.Elapsed;
            IsBestOfFive = isBestOfFive;
            this.stopwatch = stopwatch;
        }

        public Point OppPoint => Point.Love();

        public Point YouPoint => Point.Love();

        public int OppGames => 0;

        public int YouGames => 0;

        public int OppSets => 0;

        public int YouSets => 0;

        public bool YouServe { get; private set; }

        public bool YouWonThePoint => false;

        public bool IsDoubles { get; private set; }

        public bool IsBestOfFive { get; private set; }

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
