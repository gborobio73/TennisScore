using System.Diagnostics;
using MatchScore.Points;

namespace MatchScore.Scores
{
    class FourtyThirty : Score
    {
        public FourtyThirty(IScore previous, bool youWon, Stopwatch stopwatch) 
            : base(previous, youWon, stopwatch)
        {
        }

        public override Point OppPoint => YouServe ? Point.Thirty() : Point.Fourty();

        public override Point YouPoint => YouServe ? Point.Fourty() : Point.Thirty();

        protected override IScore GiveThePointToOpponent()
        {
            if (YouServe) return new FourtyAll(this, false, stopwatch);
            return new EndOfAGameUtil().GetNextScore(this, false, stopwatch);
        }

        protected override IScore GiveThePointToYou()
        {
            if (YouServe) return new EndOfAGameUtil().GetNextScore(this, true, stopwatch);
            return new FourtyAll(this, true, stopwatch);
        }
    }
}