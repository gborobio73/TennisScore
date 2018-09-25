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

        public override IScore SetOppPoint()
        {
            if (YouServe) return new NewGame(this, false, stopwatch);
            return new FourtyAll(this, false, stopwatch);
        }

        public override IScore SetYouPoint()
        {
            if (YouServe) return new FourtyAll(this, true, stopwatch);
            return new NewGame(this, true, stopwatch);
        }
    }
}