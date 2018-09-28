using System;

using WatchKit;
using Foundation;

namespace TennisScore.WatchAppExtension
{
    public partial class InterfaceControllerHome : WKInterfaceController
    {
        protected InterfaceControllerHome(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void Awake(NSObject context)
        {
            base.Awake(context);

            // Configure interface objects here.
            Console.WriteLine("{0} awake with context", this);
        }

        public override void WillActivate()
        {
            // This method is called when the watch view controller is about to be visible to the user.
            Console.WriteLine("{0} will activate", this);
        }


        public override void DidDeactivate()
        {
            // This method is called when the watch view controller is no longer visible to the user.
            Console.WriteLine("{0} did deactivate", this);
        }

        partial void OnYouServeSwPressed(bool sender)
        {
            Configuration.Instance.YouServe = sender;
        }

        partial void OnDoublesSWPressed(bool sender)
        {
            Configuration.Instance.Doubles = sender;
        }

        partial void OnBestOfFiveSWPressed(bool sender)
        {
            Configuration.Instance.BestOfFive = sender;
        }
    }
}
