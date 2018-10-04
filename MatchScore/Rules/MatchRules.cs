using System;
using MatchScore.Scores;

namespace MatchScore.Rules
{
    public class MatchRules
    {
        public bool IsEndOfMatch(int oppSets, int youSets, bool isBestOfFive)
        {
            if (isBestOfFive)
                return oppSets == 3 || youSets == 3;// || Math.Abs(oppSets - youSets) == 2;
            return oppSets == 2 || youSets == 2;

        }

        internal bool IsTiebreakOver(int oppPoints, int youPoints)
        {
            int bestOf = 7;
            return IsTheTiebreakOver(oppPoints, youPoints, bestOf);
        }

        internal bool IsMaxiTiebreakOver(int oppPoints, int youPoints) 
        {
            int bestOf = 10;
            return IsTheTiebreakOver(oppPoints, youPoints, bestOf);
        }

        internal bool IsEndOfMatch(IScore current, bool youWonTheGame)
        {
            var oppGames = youWonTheGame ? current.OppGames : current.OppGames + 1;
            var youGames = youWonTheGame ? current.YouGames + 1 : current.YouGames;

            if(IsSetOver(oppGames, youGames)){
                var oppSets = youWonTheGame ? current.OppSets : current.OppSets + 1;
                var youSets = youWonTheGame ? current.YouSets + 1 : current.YouSets;

                return IsEndOfMatch(oppSets, youSets, current.IsBestOfFive);
            }
            return false;
         }

        internal bool IsSetOver(int oppGames, int youGames)
        {
            return ((youGames == 6 || oppGames == 6) && Math.Abs(youGames - oppGames) >= 2)
                || youGames == 7 || oppGames == 7;
        }

        internal bool IsDecidingSet(int oppSets, int youSets, bool isBestOfFive)
        {
            if (isBestOfFive)
                return oppSets == 2 && youSets == 2;
            return oppSets == 1 && youSets == 1;
        }

        internal bool IsTiebreak(int oppGames, int youGames)
        {
            return youGames == 6 && oppGames == 6;
        }

        internal bool IsMaxiTiebreak(int oppSets, int youSets, bool isBestOfFive, bool isDoubles)
        {
            if (!isDoubles) return false;
            return IsDecidingSet(oppSets, youSets, isBestOfFive);
        }

        internal bool IsTiebreakServeChange(int oppPoints, int youPoints)
        {
            if (ItIsTheBeginingOfTiebreak(oppPoints, youPoints)) return true;
            return (oppPoints + youPoints) % 2 != 0;
        }

        private static bool ItIsTheBeginingOfTiebreak(int oppPoints, int youPoints)
        {
            return oppPoints == youPoints && oppPoints == 0;
        }

        bool IsTheTiebreakOver(int oppPoints, int youPoints, int bestOf)
        {
            return (oppPoints >= bestOf || youPoints >= bestOf) && Math.Abs(youPoints - oppPoints) >= 2;

        }
    }
}
