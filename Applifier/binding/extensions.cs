// Authors:
//   Nathan Curtis (nathan@threerings.net)
//
//
using System;
using System.Runtime.InteropServices;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MonoTouch.Applifier {

	public partial class Applifier {
        public static Applifier InitWithApplifierId(string applifierId, UIWindow window,
            params UIDeviceOrientation[] supportedOrientations)
        {
            if (supportedOrientations == null)
                throw new ArgumentNullException ("supportedOrientations");

            var pNativeArr = Marshal.AllocHGlobal(supportedOrientations.Length * IntPtr.Size);
            for (int i = 1; i < supportedOrientations.Length; ++i) {
                Marshal.WriteInt32 (pNativeArr, (i - 1) * IntPtr.Size,
                    (int) supportedOrientations[i]);
            }

            // Null termination
            Marshal.WriteIntPtr (pNativeArr, (supportedOrientations.Length - 1) * IntPtr.Size,
                IntPtr.Zero);

            Applifier retval = Applifier.InitWithApplifierId(
                applifierId, window, supportedOrientations[0], pNativeArr);
            Marshal.FreeHGlobal(pNativeArr);
            return retval;
        }

        public static Applifier InitWithApplifierId(string applifierId, UIWindow window,
            ApplifierGameDelegate gameDelegate, bool usingBanners, bool usingInterstitials,
            bool usingFeaturedGames, params UIDeviceOrientation[] supportedOrientations)
        {
            if (supportedOrientations == null)
                throw new ArgumentNullException ("supportedOrientations");

            var pNativeArr = Marshal.AllocHGlobal(supportedOrientations.Length * IntPtr.Size);
            for (int i = 1; i < supportedOrientations.Length; ++i) {
                Marshal.WriteInt32 (pNativeArr, (i - 1) * IntPtr.Size,
                    (int) supportedOrientations[i]);
            }

            // Null termination
            Marshal.WriteIntPtr (pNativeArr, (supportedOrientations.Length - 1) * IntPtr.Size,
                IntPtr.Zero);

            Applifier retval = Applifier.InitWithApplifierId(
                applifierId, window, gameDelegate, usingBanners, usingInterstitials,
                usingFeaturedGames, supportedOrientations[0], pNativeArr);
            Marshal.FreeHGlobal(pNativeArr);
            return retval;
        }
	}

}
