using System;
namespace JinglePeerconnectionBindingDemo
{
	public class ARDAppClient : IARDAppClient
	{
		//    // TODO(tkchin): move these to a configuration object.
		//static NSString *kARDRoomServerHostUrl =
		//    @"https://apprtc.appspot.com";
		//static NSString *kARDRoomServerRegisterFormat =
		//    @"%@/join/%@";
		//static NSString *kARDRoomServerMessageFormat =
		//    @"%@/message/%@/%@";
		//static NSString *kARDRoomServerByeFormat =
		//    @"%@/leave/%@/%@";

		//static NSString *kARDDefaultSTUNServerUrl =
		//    @"stun:stun.l.google.com:19302";
		//// TODO(tkchin): figure out a better username for CEOD statistics.
		//static NSString *kARDTurnRequestUrl =
		//    @"https://computeengineondemand.appspot.com"
		//    @"/turn?username=iapprtc&key=4080218913";

		static string kARDAppClientErrorDomain = "ARDAppClient";
		static int kARDAppClientErrorUnknown = -1;
		static int kARDAppClientErrorRoomFull = -2;
		static int kARDAppClientErrorCreateSDP = -3;
		static int kARDAppClientErrorSetSDP = -4;
		static int kARDAppClientErrorNetwork = -5;
		static int kARDAppClientErrorInvalidClient = -6;
		static int kARDAppClientErrorInvalidRoom = -7;
		string kARDRoomServerHostUrl = "https://apprtc.appspot.com";
		string kARDRoomServerByeFormat = "";
		string kARDDefaultSTUNServerUrl = "stun:stun.l.google.com:19302";
		string kARDTurnRequestUrl = "https://computeengineondemand.appspot.com/turn?username=iapprtc&key=4080218913";
		ARDAppClientState _state;
		IARDAppClientDelegate _delegate;

		public IARDAppClientDelegate ARDAppClientDelegate => _delegate;

		public ARDAppClient(IARDAppClientDelegate ardpAppDelegate)
		{
			_delegate = ardpAppDelegate;
		}

		public void ConnectToRoomWithId(string roomName)
		{
			//throw new NotImplementedException();
		}

		public void Disconnect()
		{
			if (_state == ARDAppClientState.Disconnected)
				return;


			//	 if (_state == kARDAppClientStateDisconnected) {
			//  return;
			//}
			//if (self.isRegisteredWithRoomServer) {
			//  [self unregisterWithRoomServer];
			//}
			//if (_channel) {
			//  if (_channel.state == kARDWebSocketChannelStateRegistered) {
			//    // Tell the other client we're hanging up.
			//    ARDByeMessage *byeMessage = [[ARDByeMessage alloc] init];
			//    NSData *byeData = [byeMessage JSONData];
			//    [_channel sendData:byeData];
			//  }
			//  // Disconnect from collider.
			//  _channel = nil;
			//}
			//_clientId = nil;
			//_roomId = nil;
			//_isInitiator = NO;
			//_hasReceivedSdp = NO;
			//_messageQueue = [NSMutableArray array];
			//_peerConnection = nil;
			//self.state = kARDAppClientStateDisconnected;
		}

		public void MuteAudioIn()
		{
			//throw new NotImplementedException();
		}

		public void SetServerHostUrl(string serverHostUrl)
		{
			//throw new NotImplementedException();
		}

		public void SwapCameraToBack()
		{
			//throw new NotImplementedException();
		}

		public void SwapCameraToFront()
		{
			//throw new NotImplementedException();
		}

		public void UnmuteAudioIn()
		{
			//throw new NotImplementedException();
		}
		void SetState(ARDAppClientState state)
		{
			if (_state == state)
			{
				return;
			}
			_state = state;

			_delegate.DidChangeState(this, state);

		}
	}
}
