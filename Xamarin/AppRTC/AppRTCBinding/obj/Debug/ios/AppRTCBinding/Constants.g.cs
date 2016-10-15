//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace AppRTCBinding {
	public unsafe static partial class Constants  {
		
		[CompilerGenerated]
		static NSString _SRHTTPResponseErrorKey;
		[Field ("SRHTTPResponseErrorKey",  "__Internal")]
		public static unsafe NSString SRHTTPResponseErrorKey {
			get {
				if (_SRHTTPResponseErrorKey == null)
					_SRHTTPResponseErrorKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "SRHTTPResponseErrorKey");
				return _SRHTTPResponseErrorKey;
			}
		}
		[CompilerGenerated]
		static NSString _SRWebSocketErrorDomain;
		[Field ("SRWebSocketErrorDomain",  "__Internal")]
		public static unsafe NSString SRWebSocketErrorDomain {
			get {
				if (_SRWebSocketErrorDomain == null)
					_SRWebSocketErrorDomain = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "SRWebSocketErrorDomain");
				return _SRWebSocketErrorDomain;
			}
		}
	} /* class Constants */
}
