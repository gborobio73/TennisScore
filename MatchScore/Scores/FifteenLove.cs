using System;
using System.Diagnostics;
using MatchScore.Points;

namespace MatchScore.Scores
{
	class FifteenLove: Score
    {
        public FifteenLove(IScore previous, bool youWon, Stopwatch stopwatch) 
            : base(previous, youWon, stopwatch)
        {
        }

        public override Point OppPoint => YouServe ? Point.Love(): Point.Fifteen();

        public override Point YouPoint => YouServe ? Point.Fifteen() : Point.Love();

        public override IScore SetOppPoint()
        {
            if (YouServe) return new FifteenAll(this, false, stopwatch);
            return new ThirtyLove(this, false, stopwatch);
        }

        public override IScore SetYouPoint()
        {
            if (YouServe) return new ThirtyLove(this, true, stopwatch);
            return new FifteenAll(this, true, stopwatch);
        }
    }
}
