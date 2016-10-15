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
	public unsafe static partial class NSDictionary_ARDUtilites  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSDictionary");
		
		[Export ("dictionaryWithJSONData:")]
		[CompilerGenerated]
		public static NSDictionary DictionaryWithJSONData (this NSDictionary This, NSData jsonData)
		{
			if (jsonData == null)
				throw new ArgumentNullException ("jsonData");
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("dictionaryWithJSONData:"), jsonData.Handle));
		}
		
		[Export ("dictionaryWithJSONString:")]
		[CompilerGenerated]
		public static NSDictionary DictionaryWithJSONString (this NSDictionary This, string jsonString)
		{
			if (jsonString == null)
				throw new ArgumentNullException ("jsonString");
			var nsjsonString = NSString.CreateNative (jsonString);
			
			NSDictionary ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("dictionaryWithJSONString:"), nsjsonString));
			NSString.ReleaseNative (nsjsonString);
			
			return ret;
		}
		
	} /* class NSDictionary_ARDUtilites */
}
