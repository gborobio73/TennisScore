using System.Diagnostics;
using MatchScore.Points;

namespace MatchScore.Scores
{
    class ThirtyForty : Score
    {
        public ThirtyForty(IScore previous, bool youWon, Stopwatch stopwatch) 
            : base(previous, youWon, stopwatch)
        {
        }

        public override Point OppPoint => YouServe ? Point.Fourty() : Point.Thirty();

        public override Point YouPoint => YouServe ? Point.Thirty() : Point.Fourty();

        protected override IScore GiveThePointToOpponent()
        {
            if (YouServe) return new EndOfAGameUtil().GetNextScore(this, false, stopwatch);
            return new FourtyAll(this, false, stopwatch);
        }

        protected override IScore GiveThePointToYou()
        {
            if (YouServe) return new FourtyAll(this, true, stopwatch);
            return new EndOfAGameUtil().GetNextScore(this, true, stopwatch);
        }
    }
}