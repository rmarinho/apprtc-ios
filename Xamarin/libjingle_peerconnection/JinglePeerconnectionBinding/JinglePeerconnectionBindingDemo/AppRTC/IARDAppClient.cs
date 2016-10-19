using System;
using Foundation;
using JinglePeerconnectionBinding;

namespace JinglePeerconnectionBindingDemo
{

	public enum ARDAppClientState : long
	{
		Disconnected,
		Connecting,
		Connected
	}
	public interface IARDAppClient
	{
		void SetServerHostUrl(string serverHostUrl);
		void ConnectToRoomWithId(string roomName);
		void Disconnect();
		void SwapCameraToBack();
		void SwapCameraToFront();
		void MuteAudioIn();
		void UnmuteAudioIn();
		IARDAppClientDelegate ARDAppClientDelegate { get; }
	}

	public interface IARDAppClientDelegate
	{
		// @required -(void)appClient:(ARDAppClient *)client didChangeState:(ARDAppClientState)state;
		//[Abstract]
		//[Export("appClient:didChangeState:")]
		void DidChangeState(IARDAppClient client, ARDAppClientState state);

		// @required -(void)appClient:(ARDAppClient *)client didReceiveLocalVideoTrack:(RTCVideoTrack *)localVideoTrack;
		//[Abstract]
		//[Export("appClient:didReceiveLocalVideoTrack:")]
		void DidReceiveLocalVideoTrack(IARDAppClient client, RTCVideoTrack localVideoTrack);

		// @required -(void)appClient:(ARDAppClient *)client didReceiveRemoteVideoTrack:(RTCVideoTrack *)remoteVideoTrack;
		//[Abstract]
		//[Export("appClient:didReceiveRemoteVideoTrack:")]
		void DidReceiveRemoteVideoTrack(IARDAppClient client, RTCVideoTrack remoteVideoTrack);

		// @required -(void)appClient:(ARDAppClient *)client didError:(NSError *)error;
		//[Abstract]
		//[Export("appClient:didError:")]
		void DidError(IARDAppClient client, NSError error);
	}
}
