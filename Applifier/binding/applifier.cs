// Authors:
//   Nathan Curtis (nathan@threerings.net)
//
//
using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;

namespace MonoTouch.ApplifierWrapper {

    [BaseType (typeof (NSObject))]
    interface ApplifierWrapper {
        [Export ("init:withWindow:supportedOrientations:"), Static]
        void Init (string applifierId, UIWindow withWindow,
            UIDeviceOrientation firstOrientation, IntPtr orientationsPtr);

        [Export ("prepareFeaturedGames"), Static]
        void PrepareFeaturedGames ();

        [Export ("showFeaturedGames"), Static]
        void ShowFeaturedGames ();
    }
}
