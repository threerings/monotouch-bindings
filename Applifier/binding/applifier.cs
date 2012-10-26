// Authors:
//   Nathan Curtis (nathan@threerings.net)
//
//
using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;

namespace MonoTouch.Applifier {

    [BaseType (typeof (NSObject))]
    interface Applifier {
        [Export ("initWithApplifierID:withWindow:supportedOrientations:"), Static]
        Applifier InitWithApplifierId (string applifierId, UIWindow withWindow,
            UIDeviceOrientation firstOrientation, IntPtr orientationsPtr);

        [Export ("initWithApplifierID:withWindow:delegate:usingBanners:usingInterstitials:usingFeaturedGames:supportedOrientations:"), Static]
        Applifier InitWithApplifierId (string applifierId, UIWindow withWindow,
            ApplifierGameDelegate gameDelegate, bool usingBanners, bool usingInterstitials,
            bool usingFeaturedGames, UIDeviceOrientation firstOrientation, IntPtr orientationsPtr);

        [Export ("sharedInstance"), Static]
        Applifier SharedInstance { get; }

        [Wrap ("WeakDelegate")]
        ApplifierGameDelegate Delegate { get; set; }

        [Export ("gameDelegate", ArgumentSemantic.Retain)]
        NSObject WeakDelegate { get; set; }

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
        [Export("applifierInterstitialReady"), Abstract]
        void InterstitialReady ();

        [Export("applifierFeaturedGamesReady"), Abstract]
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
