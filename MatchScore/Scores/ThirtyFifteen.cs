using System.Diagnostics;
using MatchScore.Points;

namespace MatchScore.Scores
{
    class ThirtyFifteen : Score
    {
        public ThirtyFifteen(IScore previous, bool youWon, Stopwatch stopwatch) 
            : base(previous, youWon, stopwatch)
        {
        }

        public override Point OppPoint => YouServe ? Point.Fifteen() : Point.Thirty();

        public override Point YouPoint => YouServe ? Point.Thirty() : Point.Fifteen();

        protected override IScore GiveThePointToOpponent()
        {
            if (YouServe) return new ThirtyAll(this, false, stopwatch);
            return new FourtyFifteen(this, false, stopwatch);
        }

        protected override IScore GiveThePointToYou()
        {
            if (YouServe) return new FourtyFifteen(this, true, stopwatch);
            return new ThirtyAll(this, true, stopwatch);
        }
    }
}