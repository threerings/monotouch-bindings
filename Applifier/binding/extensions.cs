using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MonoTouch.Applifier {

	public partial class Applifier {
        public static Applifier InitWithApplifierId(string applifierId, UIWindow window,
            params UIDeviceOrientation[] supportedOrientations)
        {
            if (supportedOrientations == null)
                throw new ArgumentNullException("supportedOrientations");

            NSMutableArray orientationsArray = new NSMutableArray(supportedOrientations.Length);
            for (int i = 1; i < supportedOrientations.Length; ++i) {
                orientationsArray.Add(NSNumber.FromInt32((int) supportedOrientations[i]));
            }

            return Applifier.InitWithApplifierID(applifierId, window, orientationsArray);
        }
	}

}
