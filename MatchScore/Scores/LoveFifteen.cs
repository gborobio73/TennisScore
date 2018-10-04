using System;
using System.Diagnostics;
using MatchScore.Points;

namespace MatchScore.Scores
{
	class LoveFifteen : Score
    {
        public LoveFifteen(IScore previous, bool youWon, Stopwatch stopwatch) 
            : base(previous, youWon, stopwatch)
        {
        }

        public override Point OppPoint => YouServe ? Point.Fifteen() : Point.Love();

        public override Point YouPoint => YouServe ? Point.Love() : Point.Fifteen();

        protected override IScore GiveThePointToOpponent()
        {
            if (YouServe) return new LoveThirty(this, false, stopwatch);
            return new FifteenAll(this, false, stopwatch);
        }

        protected override IScore GiveThePointToYou()
        {
            if (YouServe) return new FifteenAll(this, true, stopwatch);
            return new LoveThirty(this, true, stopwatch);
        }
    }
}
