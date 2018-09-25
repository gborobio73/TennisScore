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

        public override IScore SetOppPoint()
        {
            if (YouServe) return new LoveThirty(this, false, stopwatch);
            return new FifteenAll(this, false, stopwatch);
        }

        public override IScore SetYouPoint()
        {
            if (YouServe) return new FifteenAll(this, true, stopwatch);
            return new LoveThirty(this, true, stopwatch);
        }
    }
}
