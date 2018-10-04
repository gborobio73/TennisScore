using System.Diagnostics;
using MatchScore.Points;

namespace MatchScore.Scores
{
    class YourAdvantage : Score
    {
        public YourAdvantage(IScore previous, bool youWon, Stopwatch stopwatch) 
            : base(previous, youWon, stopwatch)
        {
        }

        public override Point OppPoint => Point.Fourty();

        public override Point YouPoint => Point.Ad();

        protected override IScore GiveThePointToOpponent()
        {
            return new FourtyAll(this, false, stopwatch);
        }

        protected override IScore GiveThePointToYou()
        {
            return new EndOfAGameUtil().GetNextScore(this, true, stopwatch);

        }
    }
}