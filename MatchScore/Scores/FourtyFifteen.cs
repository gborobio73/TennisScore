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

        protected override IScore GiveThePointToOpponent()
        {
            if (YouServe) return new FourtyThirty(this, false, stopwatch);
            return new EndOfAGameUtil().GetNextScore(this, false, stopwatch);
        }

        protected override IScore GiveThePointToYou()
        {
            if (YouServe) return new EndOfAGameUtil().GetNextScore(this, true, stopwatch);
            return new FourtyThirty(this, true, stopwatch);
        }
    }
}