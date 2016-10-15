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
	[Register("SRWebSocket", true)]
	public unsafe partial class SRWebSocket : NSObject, INSStreamDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SRWebSocket");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SRWebSocket () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SRWebSocket (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SRWebSocket (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithURLRequest:protocols:allowsUntrustedSSLCertificates:")]
		[CompilerGenerated]
		public SRWebSocket (NSUrlRequest request, NSObject[] protocols, bool allowsUntrustedSSLCertificates)
			: base (NSObjectFlag.Empty)
		{
			if (request == null)
				throw new ArgumentNullException ("request");
			if (protocols == null)
				throw new ArgumentNullException ("protocols");
			var nsa_protocols = NSArray.FromNSObjects (protocols);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("initWithURLRequest:protocols:allowsUntrustedSSLCertificates:"), request.Handle, nsa_protocols.Handle, allowsUntrustedSSLCertificates), "initWithURLRequest:protocols:allowsUntrustedSSLCertificates:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("initWithURLRequest:protocols:allowsUntrustedSSLCertificates:"), request.Handle, nsa_protocols.Handle, allowsUntrustedSSLCertificates), "initWithURLRequest:protocols:allowsUntrustedSSLCertificates:");
			}
			nsa_protocols.Dispose ();
			
		}
		
		[Export ("initWithURLRequest:protocols:")]
		[CompilerGenerated]
		public SRWebSocket (NSUrlRequest request, NSObject[] protocols)
			: base (NSObjectFlag.Empty)
		{
			if (request == null)
				throw new ArgumentNullException ("request");
			if (protocols == null)
				throw new ArgumentNullException ("protocols");
			var nsa_protocols = NSArray.FromNSObjects (protocols);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithURLRequest:protocols:"), request.Handle, nsa_protocols.Handle), "initWithURLRequest:protocols:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithURLRequest:protocols:"), request.Handle, nsa_protocols.Handle), "initWithURLRequest:protocols:");
			}
			nsa_protocols.Dispose ();
			
		}
		
		[Export ("initWithURLRequest:")]
		[CompilerGenerated]
		public SRWebSocket (NSUrlRequest request)
			: base (NSObjectFlag.Empty)
		{
			if (request == null)
				throw new ArgumentNullException ("request");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithURLRequest:"), request.Handle), "initWithURLRequest:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithURLRequest:"), request.Handle), "initWithURLRequest:");
			}
		}
		
		[Export ("initWithURL:protocols:allowsUntrustedSSLCertificates:")]
		[CompilerGenerated]
		public SRWebSocket (NSUrl url, NSObject[] protocols, bool allowsUntrustedSSLCertificates)
			: base (NSObjectFlag.Empty)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (protocols == null)
				throw new ArgumentNullException ("protocols");
			var nsa_protocols = NSArray.FromNSObjects (protocols);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("initWithURL:protocols:allowsUntrustedSSLCertificates:"), url.Handle, nsa_protocols.Handle, allowsUntrustedSSLCertificates), "initWithURL:protocols:allowsUntrustedSSLCertificates:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("initWithURL:protocols:allowsUntrustedSSLCertificates:"), url.Handle, nsa_protocols.Handle, allowsUntrustedSSLCertificates), "initWithURL:protocols:allowsUntrustedSSLCertificates:");
			}
			nsa_protocols.Dispose ();
			
		}
		
		[Export ("initWithURL:protocols:")]
		[CompilerGenerated]
		public SRWebSocket (NSUrl url, NSObject[] protocols)
			: base (NSObjectFlag.Empty)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (protocols == null)
				throw new ArgumentNullException ("protocols");
			var nsa_protocols = NSArray.FromNSObjects (protocols);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithURL:protocols:"), url.Handle, nsa_protocols.Handle), "initWithURL:protocols:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithURL:protocols:"), url.Handle, nsa_protocols.Handle), "initWithURL:protocols:");
			}
			nsa_protocols.Dispose ();
			
		}
		
		[Export ("initWithURL:")]
		[CompilerGenerated]
		public SRWebSocket (NSUrl url)
			: base (NSObjectFlag.Empty)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithURL:"), url.Handle), "initWithURL:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithURL:"), url.Handle), "initWithURL:");
			}
		}
		
		[Export ("close")]
		[CompilerGenerated]
		public virtual void Close ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("close"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("close"));
			}
		}
		
		[Export ("closeWithCode:reason:")]
		[CompilerGenerated]
		public virtual void CloseWithCode (global::System.nint code, string reason)
		{
			if (reason == null)
				throw new ArgumentNullException ("reason");
			var nsreason = NSString.CreateNative (reason);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nint_IntPtr (this.Handle, Selector.GetHandle ("closeWithCode:reason:"), code, nsreason);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint_IntPtr (this.SuperHandle, Selector.GetHandle ("closeWithCode:reason:"), code, nsreason);
			}
			NSString.ReleaseNative (nsreason);
			
		}
		
		[Export ("open")]
		[CompilerGenerated]
		public virtual void Open ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("open"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("open"));
			}
		}
		
		[Export ("scheduleInRunLoop:forMode:")]
		[CompilerGenerated]
		public virtual void ScheduleInRunLoop (NSRunLoop aRunLoop, string mode)
		{
			if (aRunLoop == null)
				throw new ArgumentNullException ("aRunLoop");
			if (mode == null)
				throw new ArgumentNullException ("mode");
			var nsmode = NSString.CreateNative (mode);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("scheduleInRunLoop:forMode:"), aRunLoop.Handle, nsmode);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("scheduleInRunLoop:forMode:"), aRunLoop.Handle, nsmode);
			}
			NSString.ReleaseNative (nsmode);
			
		}
		
		[Export ("send:")]
		[CompilerGenerated]
		public virtual void Send (NSObject data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("send:"), data.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("send:"), data.Handle);
			}
		}
		
		[Export ("sendPing:")]
		[CompilerGenerated]
		public virtual void SendPing (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("sendPing:"), data.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("sendPing:"), data.Handle);
			}
		}
		
		[Export ("setDelegateDispatchQueue:")]
		[CompilerGenerated]
		public virtual void SetDelegateDispatchQueue (global::CoreFoundation.DispatchQueue queue)
		{
			if (queue == null)
				throw new ArgumentNullException ("queue");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegateDispatchQueue:"), queue.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegateDispatchQueue:"), queue.Handle);
			}
		}
		
		[Export ("setDelegateOperationQueue:")]
		[CompilerGenerated]
		public virtual void SetDelegateOperationQueue (NSOperationQueue queue)
		{
			if (queue == null)
				throw new ArgumentNullException ("queue");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegateOperationQueue:"), queue.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegateOperationQueue:"), queue.Handle);
			}
		}
		
		[Export ("unscheduleFromRunLoop:forMode:")]
		[CompilerGenerated]
		public virtual void UnscheduleFromRunLoop (NSRunLoop aRunLoop, string mode)
		{
			if (aRunLoop == null)
				throw new ArgumentNullException ("aRunLoop");
			if (mode == null)
				throw new ArgumentNullException ("mode");
			var nsmode = NSString.CreateNative (mode);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("unscheduleFromRunLoop:forMode:"), aRunLoop.Handle, nsmode);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("unscheduleFromRunLoop:forMode:"), aRunLoop.Handle, nsmode);
			}
			NSString.ReleaseNative (nsmode);
			
		}
		
		[CompilerGenerated]
		public SRWebSocketDelegate Delegate {
			get {
				return WeakDelegate as SRWebSocketDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string Protocol {
			[Export ("protocol")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("protocol")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("protocol")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual SRReadyState ReadyState {
			[Export ("readyState")]
			get {
				SRReadyState ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (SRReadyState) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("readyState"));
					} else {
						ret = (SRReadyState) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("readyState"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (SRReadyState) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("readyState"));
					} else {
						ret = (SRReadyState) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("readyState"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_RequestCookies_var;
		[CompilerGenerated]
		public virtual NSObject[] RequestCookies {
			[Export ("requestCookies", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("requestCookies")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requestCookies")));
				}
				MarkDirty ();
				__mt_RequestCookies_var = ret;
				return ret;
			}
			
			[Export ("setRequestCookies:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRequestCookies:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRequestCookies:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				MarkDirty ();
				__mt_RequestCookies_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual NSUrl Url {
			[Export ("url", ArgumentSemantic.Retain)]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("url")));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("url")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_RequestCookies_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class SRWebSocket */
}
