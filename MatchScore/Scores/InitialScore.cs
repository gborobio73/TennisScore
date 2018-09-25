using System;
using System.Diagnostics;
using MatchScore.Points;

namespace MatchScore.Scores
{
    class InitialScore : IScore
    {
        readonly Stopwatch stopwatch;

        internal InitialScore(bool youServe, Stopwatch stopwatch)
        {
            YouServe = youServe;
            ElapsedPointTime = stopwatch.Elapsed;
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

        public TimeSpan ElapsedPointTime { get; private set; }

        public bool IsEndOfMatch()
        {
            return false;
        }

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
