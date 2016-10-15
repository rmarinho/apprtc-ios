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
	[Protocol (Name = "ARDAppClientDelegate", WrapperType = typeof (ARDAppClientDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveLocalVideoTrack", Selector = "appClient:didReceiveLocalVideoTrack:", ParameterType = new Type [] { typeof (AppRTCBinding.ARDAppClient), typeof (AppRTCBinding.RTCVideoTrack) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveRemoteVideoTrack", Selector = "appClient:didReceiveRemoteVideoTrack:", ParameterType = new Type [] { typeof (AppRTCBinding.ARDAppClient), typeof (AppRTCBinding.RTCVideoTrack) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidError", Selector = "appClient:didError:", ParameterType = new Type [] { typeof (AppRTCBinding.ARDAppClient), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	public interface IARDAppClientDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("appClient:didReceiveLocalVideoTrack:")]
		[Preserve (Conditional = true)]
		void DidReceiveLocalVideoTrack (ARDAppClient client, RTCVideoTrack localVideoTrack);
		
		[CompilerGenerated]
		[Export ("appClient:didReceiveRemoteVideoTrack:")]
		[Preserve (Conditional = true)]
		void DidReceiveRemoteVideoTrack (ARDAppClient client, RTCVideoTrack remoteVideoTrack);
		
		[CompilerGenerated]
		[Export ("appClient:didError:")]
		[Preserve (Conditional = true)]
		void DidError (ARDAppClient client, NSError error);
		
	}
	
	internal sealed class ARDAppClientDelegateWrapper : BaseWrapper, IARDAppClientDelegate {
		public ARDAppClientDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public ARDAppClientDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("appClient:didReceiveLocalVideoTrack:")]
		[CompilerGenerated]
		public void DidReceiveLocalVideoTrack (ARDAppClient client, RTCVideoTrack localVideoTrack)
		{
			if (client == null)
				throw new ArgumentNullException ("client");
			if (localVideoTrack == null)
				throw new ArgumentNullException ("localVideoTrack");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("appClient:didReceiveLocalVideoTrack:"), client.Handle, localVideoTrack.Handle);
		}
		
		[Export ("appClient:didReceiveRemoteVideoTrack:")]
		[CompilerGenerated]
		public void DidReceiveRemoteVideoTrack (ARDAppClient client, RTCVideoTrack remoteVideoTrack)
		{
			if (client == null)
				throw new ArgumentNullException ("client");
			if (remoteVideoTrack == null)
				throw new ArgumentNullException ("remoteVideoTrack");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("appClient:didReceiveRemoteVideoTrack:"), client.Handle, remoteVideoTrack.Handle);
		}
		
		[Export ("appClient:didError:")]
		[CompilerGenerated]
		public void DidError (ARDAppClient client, NSError error)
		{
			if (client == null)
				throw new ArgumentNullException ("client");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("appClient:didError:"), client.Handle, error.Handle);
		}
		
	}
}
namespace AppRTCBinding {
	[Protocol]
	[Register("ARDAppClientDelegate", false)]
	[Model]
	public unsafe abstract partial class ARDAppClientDelegate : NSObject, IARDAppClientDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ARDAppClientDelegate () : base (NSObjectFlag.Empty)
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
		protected ARDAppClientDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ARDAppClientDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("appClient:didError:")]
		[CompilerGenerated]
		public abstract void DidError (ARDAppClient client, NSError error);
		[Export ("appClient:didReceiveLocalVideoTrack:")]
		[CompilerGenerated]
		public abstract void DidReceiveLocalVideoTrack (ARDAppClient client, RTCVideoTrack localVideoTrack);
		[Export ("appClient:didReceiveRemoteVideoTrack:")]
		[CompilerGenerated]
		public abstract void DidReceiveRemoteVideoTrack (ARDAppClient client, RTCVideoTrack remoteVideoTrack);
	} /* class ARDAppClientDelegate */
}
