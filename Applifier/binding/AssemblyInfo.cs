using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("Applifier.a", LinkTarget.Simulator | LinkTarget.ArmV6 | LinkTarget.ArmV7, ForceLoad = true, Frameworks = "CoreGraphics")]
