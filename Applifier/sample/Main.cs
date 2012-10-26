using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

using MonoTouch.Applifier;

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

      Applifier.InitWithApplifierId(AppId, (UIWindow) p.uiOverlay().Superview.Superview, UIDeviceOrientation.Portrait);
      Applifier.SharedInstance.Delegate = new GameDelegate();
      Console.WriteLine ("GameDelegate: " + Applifier.SharedInstance.Delegate);
      Console.WriteLine ("Preparing featured games");
      Applifier.SharedInstance.PrepareFeaturedGames();
      Applifier.SharedInstance.ShowBannerAt(new PointF(10, 10));

      return true;
    }
  }

  class GameDelegate : ApplifierGameDelegate {
    public GameDelegate () {
      Console.Out.WriteLine ("Created GameDelegate");
    }

    public override void FeaturedGamesReady () {
      Console.Out.WriteLine ("FeaturedGamesReady");
    }

    public override void InterstitialReady () {
    }

    public override void PauseGame () {
      Console.WriteLine ("PauseGame");
    }
  }

  public class Application {
    static void Main (string[] args) {
      UIApplication.Main (args, null, "AppDelegate");
    }
  }
}

