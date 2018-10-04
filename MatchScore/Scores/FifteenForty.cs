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

        protected override IScore GiveThePointToOpponent()
        {
            if (YouServe) return new EndOfAGameUtil().GetNextScore(this, false, stopwatch);
            return new ThirtyForty(this, false, stopwatch);
        }

        protected override IScore GiveThePointToYou()
        {
            if (YouServe) return new ThirtyForty(this, true, stopwatch);
            return new EndOfAGameUtil().GetNextScore(this, true, stopwatch);
        }
    }
}