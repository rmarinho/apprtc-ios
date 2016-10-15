using System;
using Foundation;
using UIKit;
using SocketRocketBinding;

namespace SocketRocket.App
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		const string _socketUrl = "https://apprtc.appspot.com";
		SRWebSocket _socket;
		public override void ViewDidLoad()
		{
			//	 _socket = [[SRWebSocket alloc] initWithURL:url];
			_socket = new SRWebSocket(new NSUrlRequest(new NSUrl(_socketUrl)));
			//_socket.delegate = self;
			//NSLog(@"Opening WebSocket.");
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
