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

		public ARDAppClient()
		{
		}

		public void ConnectToRoomWithId(string roomName)
		{
			//throw new NotImplementedException();
		}

		public void Disconnect()
		{
			//throw new NotImplementedException();
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
	}
}
