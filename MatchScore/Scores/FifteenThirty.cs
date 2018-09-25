using System;
using System.Diagnostics;
using MatchScore.Points;

namespace MatchScore.Scores
{
    class FifteenThirty : Score
    {
        public FifteenThirty(IScore previous, bool youWon, Stopwatch stopwatch) 
            : base(previous, youWon, stopwatch)
        {
        }

        public override Point OppPoint => YouServe ? Point.Thirty() : Point.Fifteen();

        public override Point YouPoint => YouServe ? Point.Fifteen() : Point.Thirty();

        public override IScore SetOppPoint()
        {
            if (YouServe) return new FifteenForty(this, false, stopwatch);
            return new ThirtyAll(this, false, stopwatch);
        }

        public override IScore SetYouPoint()
        {
            if (YouServe) return new ThirtyAll(this, true, stopwatch);
            return new FifteenForty(this, true, stopwatch);
        }
    }
}