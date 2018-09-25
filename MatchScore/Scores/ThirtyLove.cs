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

        public override IScore SetOppPoint()
        {
            if (YouServe) return new ThirtyFifteen(this, false, stopwatch);
            return new FourtyLove(this, false, stopwatch);
        }
        public override IScore SetYouPoint()
        {
            if (YouServe) return new FourtyLove(this, true, stopwatch);
            return new ThirtyFifteen(this, true, stopwatch);
        }
    }
}