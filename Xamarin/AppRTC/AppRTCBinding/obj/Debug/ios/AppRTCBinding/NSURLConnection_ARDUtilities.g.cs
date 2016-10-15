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
	public unsafe static partial class NSURLConnection_ARDUtilities  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSURLConnection");
		
		[Export ("sendAsyncPostToURL:withData:completionHandler:")]
		[CompilerGenerated]
		public unsafe static void SendAsyncPostToURL (this NSUrlConnection This, NSUrl url, NSData data, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<bool, NSData> completionHandler)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (data == null)
				throw new ArgumentNullException ("data");
			if (completionHandler == null)
				throw new ArgumentNullException ("completionHandler");
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			block_completionHandler = new BlockLiteral ();
			block_ptr_completionHandler = &block_completionHandler;
			block_completionHandler.SetupBlock (Trampolines.SDActionArity2V0.Handler, completionHandler);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("sendAsyncPostToURL:withData:completionHandler:"), url.Handle, data.Handle, (IntPtr) block_ptr_completionHandler);
			block_ptr_completionHandler->CleanupBlock ();
			
		}
		
	} /* class NSURLConnection_ARDUtilities */
}
