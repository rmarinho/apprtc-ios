using System;

namespace JinglePeerconnectionBindingDemo
{

	public interface IARDWebSocketChannelDelegate
	{
		void DidChangeState(ARDWebSocketChannelState state);
		void DidReceiveMessage(ARDSignalingMessage message);
	}
}