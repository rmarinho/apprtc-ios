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
	[Register("RTCICECandidate", true)]
	public unsafe partial class RTCICECandidate : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("RTCICECandidate");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected RTCICECandidate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal RTCICECandidate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithMid:index:sdp:")]
		[CompilerGenerated]
		public RTCICECandidate (string sdpMid, global::System.nint sdpMLineIndex, string sdp)
			: base (NSObjectFlag.Empty)
		{
			if (sdpMid == null)
				throw new ArgumentNullException ("sdpMid");
			if (sdp == null)
				throw new ArgumentNullException ("sdp");
			var nssdpMid = NSString.CreateNative (sdpMid);
			var nssdp = NSString.CreateNative (sdp);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_nint_IntPtr (this.Handle, Selector.GetHandle ("initWithMid:index:sdp:"), nssdpMid, sdpMLineIndex, nssdp), "initWithMid:index:sdp:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_nint_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithMid:index:sdp:"), nssdpMid, sdpMLineIndex, nssdp), "initWithMid:index:sdp:");
			}
			NSString.ReleaseNative (nssdpMid);
			NSString.ReleaseNative (nssdp);
			
		}
		
		[CompilerGenerated]
		public virtual string Sdp {
			[Export ("sdp")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sdp")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sdp")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string SdpMid {
			[Export ("sdpMid")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sdpMid")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sdpMid")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nint SdpMLineIndex {
			[Export ("sdpMLineIndex")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("sdpMLineIndex"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sdpMLineIndex"));
				}
			}
			
		}
		
	} /* class RTCICECandidate */
}
