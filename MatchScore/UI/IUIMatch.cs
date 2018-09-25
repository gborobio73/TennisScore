using System;
using System.Collections.Generic;

namespace MatchScore.UI
{
    public interface IUIMatch
    {
        string Duration { get; }
        List<IUIScore> Scores { get; }
    }

    class UIMatch : IUIMatch
    {
        public string Duration { get; private set; }
        public List<IUIScore> Scores { get; private set; }

        public UIMatch(TimeSpan duration, List<IUIScore> scores)
        {
            Duration = duration.ToString("hh\\:mm\\:ss");
            Scores = scores;
        }
    }
}
