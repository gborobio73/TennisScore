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

        protected override IScore GiveThePointToOpponent()
        {
            if (YouServe) return new FifteenForty(this, false, stopwatch);
            return new ThirtyAll(this, false, stopwatch);
        }

        protected override IScore GiveThePointToYou()
        {
            if (YouServe) return new ThirtyAll(this, true, stopwatch);
            return new FifteenForty(this, true, stopwatch);
        }
    }
}