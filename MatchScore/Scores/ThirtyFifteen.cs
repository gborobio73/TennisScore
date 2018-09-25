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

        public override IScore SetOppPoint()
        {
            if (YouServe) return new ThirtyAll(this, false, stopwatch);
            return new FourtyFifteen(this, false, stopwatch);
        }

        public override IScore SetYouPoint()
        {
            if (YouServe) return new FourtyFifteen(this, true, stopwatch);
            return new ThirtyAll(this, true, stopwatch);
        }
    }
}