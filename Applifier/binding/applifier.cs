// Authors:
//   Nathan Curtis (nathan@threerings.net)
//
//
using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MonoTouch.Applifier {

    [BaseType (typeof (NSObject))]
    interface Applifier {
        [Static]
        [Export ("initWithApplifierID:withWindow:supportedOrientationsArray:"), Internal]
        Applifier InitWithApplifierID (string applifierID, UIWindow withWindow,
            NSMutableArray orientationsArray);

        [Static]
        [Export ("sharedInstance")]
        Applifier SharedInstance ();

        [Export ("gameDelegate")]
        ApplifierGameDelegate GameDelegate { get; set; }

        [Export ("prepareFeaturedGames")]
        void PrepareFeaturedGames ();

        [Export ("showFeaturedGames")]
        void ShowFeaturedGames ();

        [Export ("showBannerAt:")]
        void ShowBannerAt (PointF position);
    }

    [BaseType (typeof (NSObject))]
    [Model]
    interface ApplifierGameDelegate {
        [Export("applifierInterstitialReady")]
        void InterstitialReady ();

        [Export("applifierFeaturedGamesReady")]
        void FeaturedGamesReady ();

        [Export("applifierBannerReady")]
        void BannerReady ();

        [Export("applifierAnimatedReady")]
        void AnimatedReady ();

        [Export("applifierCustomInterstitialReady")]
        void CustomInterstitialReady ();

        [Export("pauseGame")]
        void PauseGame ();

        [Export("resumeGame")]
        void ResultGame ();
    }
}
