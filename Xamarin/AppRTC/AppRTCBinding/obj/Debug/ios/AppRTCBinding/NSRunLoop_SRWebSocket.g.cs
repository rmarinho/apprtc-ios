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
	public unsafe static partial class NSRunLoop_SRWebSocket  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSRunLoop");
		
		[CompilerGenerated]
		public static NSRunLoop SR_networkRunLoop {
			[Export ("SR_networkRunLoop")]
			get {
				NSRunLoop ret;
				ret =  Runtime.GetNSObject<NSRunLoop> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("SR_networkRunLoop")));
				return ret;
			}
			
		}
		
	} /* class NSRunLoop_SRWebSocket */
}
