using System.Diagnostics;
using MatchScore.Points;

namespace MatchScore.Scores
{
    class LoveForty : Score
    {
        public LoveForty(IScore previous, bool youWon, Stopwatch stopwatch) 
            : base(previous, youWon, stopwatch)
        {
        }

        public override Point OppPoint => YouServe ? Point.Fourty() : Point.Love();

        public override Point YouPoint => YouServe ? Point.Love() : Point.Fourty();

        protected override IScore GiveThePointToOpponent()
        {
            if (YouServe) return new EndOfAGameUtil().GetNextScore(this, false, stopwatch);
            return new FifteenForty(this, false, stopwatch);
        }

        protected override IScore GiveThePointToYou()
        {
            if (YouServe) return new FifteenForty(this, true, stopwatch);
            return new EndOfAGameUtil().GetNextScore(this, true, stopwatch);
        }
    }
}