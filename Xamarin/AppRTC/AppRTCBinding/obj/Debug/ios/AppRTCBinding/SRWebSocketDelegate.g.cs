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
	[Protocol (Name = "SRWebSocketDelegate", WrapperType = typeof (SRWebSocketDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WebSocket", Selector = "webSocket:didReceiveMessage:", ParameterType = new Type [] { typeof (AppRTCBinding.SRWebSocket), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WebSocketDidOpen", Selector = "webSocketDidOpen:", ParameterType = new Type [] { typeof (AppRTCBinding.SRWebSocket) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WebSocket", Selector = "webSocket:didFailWithError:", ParameterType = new Type [] { typeof (AppRTCBinding.SRWebSocket), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WebSocket", Selector = "webSocket:didCloseWithCode:reason:wasClean:", ParameterType = new Type [] { typeof (AppRTCBinding.SRWebSocket), typeof (nint), typeof (string), typeof (bool) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WebSocket", Selector = "webSocket:didReceivePong:", ParameterType = new Type [] { typeof (AppRTCBinding.SRWebSocket), typeof (NSData) }, ParameterByRef = new bool [] { false, false })]
	public interface ISRWebSocketDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("webSocket:didReceiveMessage:")]
		[Preserve (Conditional = true)]
		void WebSocket (SRWebSocket webSocket, NSObject message);
		
	}
	
	public static partial class SRWebSocketDelegate_Extensions {
		[CompilerGenerated]
		public static void WebSocketDidOpen (this ISRWebSocketDelegate This, SRWebSocket webSocket)
		{
			if (webSocket == null)
				throw new ArgumentNullException ("webSocket");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("webSocketDidOpen:"), webSocket.Handle);
		}
		
		[CompilerGenerated]
		public static void WebSocket (this ISRWebSocketDelegate This, SRWebSocket webSocket, NSError error)
		{
			if (webSocket == null)
				throw new ArgumentNullException ("webSocket");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("webSocket:didFailWithError:"), webSocket.Handle, error.Handle);
		}
		
		[CompilerGenerated]
		public static void WebSocket (this ISRWebSocketDelegate This, SRWebSocket webSocket, global::System.nint code, string reason, bool wasClean)
		{
			if (webSocket == null)
				throw new ArgumentNullException ("webSocket");
			if (reason == null)
				throw new ArgumentNullException ("reason");
			var nsreason = NSString.CreateNative (reason);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nint_IntPtr_bool (This.Handle, Selector.GetHandle ("webSocket:didCloseWithCode:reason:wasClean:"), webSocket.Handle, code, nsreason, wasClean);
			NSString.ReleaseNative (nsreason);
			
		}
		
		[CompilerGenerated]
		public static void WebSocket (this ISRWebSocketDelegate This, SRWebSocket webSocket, NSData pongPayload)
		{
			if (webSocket == null)
				throw new ArgumentNullException ("webSocket");
			if (pongPayload == null)
				throw new ArgumentNullException ("pongPayload");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("webSocket:didReceivePong:"), webSocket.Handle, pongPayload.Handle);
		}
		
	}
	
	internal sealed class SRWebSocketDelegateWrapper : BaseWrapper, ISRWebSocketDelegate {
		public SRWebSocketDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public SRWebSocketDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("webSocket:didReceiveMessage:")]
		[CompilerGenerated]
		public void WebSocket (SRWebSocket webSocket, NSObject message)
		{
			if (webSocket == null)
				throw new ArgumentNullException ("webSocket");
			if (message == null)
				throw new ArgumentNullException ("message");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("webSocket:didReceiveMessage:"), webSocket.Handle, message.Handle);
		}
		
	}
}
namespace AppRTCBinding {
	[Protocol]
	[Register("SRWebSocketDelegate", false)]
	[Model]
	public unsafe abstract partial class SRWebSocketDelegate : NSObject, ISRWebSocketDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected SRWebSocketDelegate () : base (NSObjectFlag.Empty)
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
		protected SRWebSocketDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SRWebSocketDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("webSocket:didReceiveMessage:")]
		[CompilerGenerated]
		public abstract void WebSocket (SRWebSocket webSocket, NSObject message);
		[Export ("webSocket:didFailWithError:")]
		[CompilerGenerated]
		public virtual void WebSocket (SRWebSocket webSocket, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("webSocket:didCloseWithCode:reason:wasClean:")]
		[CompilerGenerated]
		public virtual void WebSocket (SRWebSocket webSocket, global::System.nint code, string reason, bool wasClean)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("webSocket:didReceivePong:")]
		[CompilerGenerated]
		public virtual void WebSocket (SRWebSocket webSocket, NSData pongPayload)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("webSocketDidOpen:")]
		[CompilerGenerated]
		public virtual void WebSocketDidOpen (SRWebSocket webSocket)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class SRWebSocketDelegate */
}
