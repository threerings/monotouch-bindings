using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

using MonoTouch.ApplifierWrapper;

using playn.ios;
using playn.core;
using playn.sample.hello.core;

// This is my current testbed - it is a modified version of the "hello" sample from playn-samples.
// http://code.google.com/p/playn-samples/
//
// We're binding applifier to begin with because we need to support a "more games" button in a
// PlayN game.
namespace playn.sample.hello.ios {

  // This will need to be set to a valid Applifier app id in order to run this test.
  const string AppId = "";

  [Register ("AppDelegate")]
  public partial class AppDelegate : UIApplicationDelegate {
    public override bool FinishedLaunching (UIApplication app, NSDictionary options) {
    var p = IOSPlatform.register(app);
      p.assets().setPathPrefix("assets");
      PlayN.run(new HelloGame());

      ApplifierWrapper.Init(AppId, (UIWindow) p.uiOverlay().Superview.Superview, UIDeviceOrientation.Portrait, UIDeviceOrientations.PortraitUpsideDown);
      ApplifierWrapper.ShowFeaturedGames();

      return true;
    }
  }

  public class Application {
    static void Main (string[] args) {
      UIApplication.Main (args, null, "AppDelegate");
    }
  }
}

