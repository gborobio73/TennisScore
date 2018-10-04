using System.Diagnostics;
using MatchScore.Points;

namespace MatchScore.Scores
{
    class ThirtyLove : Score
    {
        public ThirtyLove(IScore previous, bool youWon, Stopwatch stopwatch) 
            : base(previous, youWon, stopwatch)
        {
        }

        public override Point OppPoint => YouServe ? Point.Love() : Point.Thirty();

        public override Point YouPoint => YouServe ? Point.Thirty() : Point.Love();

        protected override IScore GiveThePointToOpponent()
        {
            if (YouServe) return new ThirtyFifteen(this, false, stopwatch);
            return new FourtyLove(this, false, stopwatch);
        }
        protected override IScore GiveThePointToYou()
        {
            if (YouServe) return new FourtyLove(this, true, stopwatch);
            return new ThirtyFifteen(this, true, stopwatch);
        }
    }
}