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

        public override IScore SetOppPoint()
        {
            if (YouServe) return new ThirtyForty(this, false, stopwatch);
            return new FourtyThirty(this, false, stopwatch);
        }

        public override IScore SetYouPoint()
        {
            if (YouServe) return new FourtyThirty(this, true, stopwatch);
            return new ThirtyForty(this, true, stopwatch);
        }
    }
}