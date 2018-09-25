using System;
using MatchScore.UI;

namespace TennisScore.WatchAppExtension
{
    sealed class SharedStorage
    {
        static readonly Lazy<SharedStorage> lazy = new Lazy<SharedStorage>(() => new SharedStorage());
        public static SharedStorage Instance { get { return lazy.Value; } }
        IUIMatch match;
        SharedStorage()
        {
        }

        public void StoreMatch(IUIMatch match) 
        {
            this.match = match;
        }

        public IUIMatch GetMatch()
        {
            return match;
        }
    }
}
