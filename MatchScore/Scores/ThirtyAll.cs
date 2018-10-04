using System.Diagnostics;
using MatchScore.Points;

namespace MatchScore.Scores
{
    class ThirtyAll : Score
    {
        public ThirtyAll(IScore previous, bool youWon, Stopwatch stopwatch) 
            : base(previous, youWon, stopwatch)
        {
        }

        public override Point OppPoint => Point.Thirty();

        public override Point YouPoint => Point.Thirty();

        protected override IScore GiveThePointToOpponent()
        {
            if (YouServe) return new ThirtyForty(this, false, stopwatch);
            return new FourtyThirty(this, false, stopwatch);
        }

        protected override IScore GiveThePointToYou()
        {
            if (YouServe) return new FourtyThirty(this, true, stopwatch);
            return new ThirtyForty(this, true, stopwatch);
        }
    }
}