using System.Diagnostics;
using MatchScore.Points;

namespace MatchScore.Scores
{
    class FourtyLove : Score
    {
        public FourtyLove(IScore previous, bool youWon, Stopwatch stopwatch) 
            : base(previous, youWon, stopwatch)
        {
        }

        public override Point OppPoint => YouServe ? Point.Love() : Point.Fourty();

        public override Point YouPoint => YouServe ? Point.Fourty() : Point.Love();

        protected override IScore GiveThePointToOpponent()
        {
            if (YouServe) return new FourtyFifteen(this, false, stopwatch);
            return new EndOfAGameUtil().GetNextScore(this, false, stopwatch);
        }

        protected override IScore GiveThePointToYou()
        {
            if (YouServe) return new EndOfAGameUtil().GetNextScore(this, true, stopwatch);
            return new FourtyFifteen(this, true, stopwatch);
        }
    }
}