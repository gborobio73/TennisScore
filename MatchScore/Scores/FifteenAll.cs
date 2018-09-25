using System;
using System.Diagnostics;
using MatchScore.Points;

namespace MatchScore.Scores
{
    class FifteenAll : Score
    {
        public FifteenAll(IScore previous, bool youWon, Stopwatch stopwatch) 
            : base(previous, youWon, stopwatch)
        {
        }

        public override Point OppPoint => Point.Fifteen();

        public override Point YouPoint => Point.Fifteen();

        public override IScore SetOppPoint()
        {
            if (YouServe) return new FifteenThirty(this, false, stopwatch);
            return new ThirtyFifteen(this, false, stopwatch);
        }

        public override IScore SetYouPoint()
        {
            if (YouServe) return new ThirtyFifteen(this, true, stopwatch);
            return new FifteenThirty(this, true, stopwatch);
        }
    }
}