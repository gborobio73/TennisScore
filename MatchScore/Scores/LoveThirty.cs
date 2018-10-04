using System.Diagnostics;
using MatchScore.Points;

namespace MatchScore.Scores
{
    class LoveThirty : Score
    {
        public LoveThirty(IScore previous, bool youWon, Stopwatch stopwatch) 
            : base(previous, youWon, stopwatch)
        {
        }

        public override Point OppPoint => YouServe ? Point.Thirty() : Point.Love();

        public override Point YouPoint => YouServe ? Point.Love() : Point.Thirty();

        protected override IScore GiveThePointToOpponent()
        {
            if (YouServe) return new LoveForty(this, false, stopwatch);
            return new FifteenThirty(this, false, stopwatch);
        }

        protected override IScore GiveThePointToYou()
        {
            if (YouServe) return new FifteenThirty(this, true, stopwatch);
            return new LoveForty(this, true, stopwatch);
        }
    }
}