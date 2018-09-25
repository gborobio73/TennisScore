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

        public override IScore SetOppPoint()
        {
            return new FourtyAll(this, false, stopwatch);
        }

        public override IScore SetYouPoint()
        {
            return new NewGame(this, true, stopwatch);
        }
    }
}