using System;
using System.Diagnostics;
using MatchScore.Points;

namespace MatchScore.Scores
{
    class FifteenForty : Score
    {
        public FifteenForty(IScore previous, bool youWon, Stopwatch stopwatch) 
            : base(previous, youWon, stopwatch)
        {
        }

        public override Point OppPoint => YouServe ? Point.Fourty() : Point.Fifteen();
        public override Point YouPoint => YouServe ? Point.Fifteen() : Point.Fourty();

        public override IScore SetOppPoint()
        {
            if (YouServe) return new NewGame(this, false, stopwatch);
            return new ThirtyForty(this, false, stopwatch);
        }

        public override IScore SetYouPoint()
        {
            if (YouServe) return new ThirtyForty(this, true, stopwatch);
            return new NewGame(this, true, stopwatch);
        }
    }
}