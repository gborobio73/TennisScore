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

        public override IScore SetOppPoint()
        {
            if (YouServe) return new FourtyFifteen(this, false, stopwatch);
            return new NewGame(this, false, stopwatch);
        }

        public override IScore SetYouPoint()
        {
            if (YouServe) return new NewGame(this, true, stopwatch);
            return new FourtyFifteen(this, true, stopwatch);
        }
    }
}