//using System;
//using System.Diagnostics;
//using MatchScore.Points;
//using MatchScore.Rules;

//namespace MatchScore.Scores
//{
//    class NewGame : Score
//    {
//        readonly MatchRules matchRules = new MatchRules();
//        readonly bool isTiebreak;
//        readonly bool isMaxiTiebreak;
//        readonly bool isEndOfMatch;

//        internal NewGame(IScore previous, bool youWon, Stopwatch stopwatch)
//            : base(previous, youWon, stopwatch)
//        {
//            if (youWon) YouGames++;
//            else OppGames++;

//            YouServe = !previous.YouServe;

//            if (matchRules.IsSetOver(OppGames, YouGames))
//            {
//                if (youWon) YouSets++;
//                else OppSets++;
//                YouGames = 0;
//                OppGames = 0;

//                if (matchRules.IsEndOfMatch(OppSets, YouSets, IsBestOfFive))
//                {
//                    isEndOfMatch = true;
//                }

//                if (matchRules.IsMaxiTiebreak(OppSets, YouSets, IsBestOfFive, IsDoubles))
//                {
//                    isMaxiTiebreak = true;
//                }

//            }
//            else
//            {
//                if (matchRules.IsTiebreak(OppGames, YouGames))
//                {
//                    isTiebreak = true;
//                }
//            }
//        }

//        public override Point OppPoint => Point.Love();

//        public override Point YouPoint => Point.Love();

//        protected override IScore GiveThePointToOpponent()
//        {
//            if (isEndOfMatch) return this;

//            if (isMaxiTiebreak) return new MaxiTiebreakScore(1, 0, this, false, stopwatch);

//            if (isTiebreak) return new TiebreakScore(1, 0, this, false, stopwatch);

//            if (YouServe) return new LoveFifteen(this, false, stopwatch);
//            return new FifteenLove(this, false, stopwatch);
//        }

//        protected override IScore GiveThePointToYou()
//        {
//            if (isEndOfMatch) return this;

//            if (isMaxiTiebreak) return new MaxiTiebreakScore(0, 1, this, true, stopwatch);

//            if (isTiebreak) return new TiebreakScore(0, 1, this, true, stopwatch);

//            if (YouServe) return new FifteenLove(this, true, stopwatch);
//            return new LoveFifteen(this, true, stopwatch);
//        }

//        bool IsEndOfMatch()
//        {
//            return isEndOfMatch;
//        }

//        bool IsMaxiTiebreak()
//        {
//            return isMaxiTiebreak; ;
//        }

//        bool IsNewSet()
//        {
//            return matchRules.IsSetOver(OppGames, YouGames);
//        }
//    }
//}
