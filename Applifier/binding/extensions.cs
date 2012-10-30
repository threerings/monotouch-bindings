// Authors:
//   Nathan Curtis (nathan@threerings.net)
//
//
using System;
using System.Runtime.InteropServices;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MonoTouch.ApplifierWrapper {

	public partial class ApplifierWrapper {
        public static void Init(string applifierId, UIWindow window,
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

            ApplifierWrapper.Init(applifierId, window, supportedOrientations[0], pNativeArr);
            Marshal.FreeHGlobal(pNativeArr);
        }
	}

}
