using System;
namespace MatchScore.Scores
{
    abstract class ScoreState
    {
        protected abstract IScore GiveThePointToOpponent();
        protected abstract IScore GiveThePointToYou();

        public IScore SetOppPoint()
        {
            return GetNextScore(false);
        }

        public IScore SetYouPoint()
        {
            return GetNextScore(true);
        }

        IScore GetNextScore(bool youWon)
        {
            if (youWon) return GiveThePointToYou();
            return GiveThePointToOpponent();
        }
    }
}
