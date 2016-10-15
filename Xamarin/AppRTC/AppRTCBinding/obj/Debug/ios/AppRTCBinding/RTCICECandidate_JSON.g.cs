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
	public unsafe static partial class RTCICECandidate_JSON  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("RTCICECandidate");
		
		[Export ("candidateFromJSONDictionary:")]
		[CompilerGenerated]
		public static RTCICECandidate CandidateFromJSONDictionary (this RTCICECandidate This, NSDictionary dictionary)
		{
			if (dictionary == null)
				throw new ArgumentNullException ("dictionary");
			return  Runtime.GetNSObject<RTCICECandidate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("candidateFromJSONDictionary:"), dictionary.Handle));
		}
		
		[Export ("JSONData")]
		[CompilerGenerated]
		public static NSData JSONData (this RTCICECandidate This)
		{
			return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("JSONData")));
		}
		
	} /* class RTCICECandidate_JSON */
}
