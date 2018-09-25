using System.Diagnostics;
using MatchScore.Points;

namespace MatchScore.Scores
{
    class FourtyFifteen : Score
    {
        public FourtyFifteen(IScore previous, bool youWon, Stopwatch stopwatch) 
            : base(previous, youWon, stopwatch)
        {
        }

        public override Point OppPoint => YouServe ? Point.Fifteen() : Point.Fourty();

        public override Point YouPoint => YouServe ? Point.Fourty() : Point.Fifteen();

        public override IScore SetOppPoint()
        {
            if (YouServe) return new FourtyThirty(this, false, stopwatch);
            return new NewGame(this, false, stopwatch);
        }

        public override IScore SetYouPoint()
        {
            if (YouServe) return new NewGame(this, true, stopwatch);
            return new FourtyThirty(this, true, stopwatch);
        }
    }
}