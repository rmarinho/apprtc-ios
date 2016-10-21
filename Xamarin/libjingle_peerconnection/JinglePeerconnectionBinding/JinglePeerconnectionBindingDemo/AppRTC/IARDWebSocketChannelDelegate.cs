using System;

namespace JinglePeerconnectionBindingDemo
{

	public interface IARDWebSocketChannelDelegate
	{
		void DidChangeState(ARDWebSocketChannelState state);
		void didReceiveMessage(ARDSignalingMessage message);
	}

	//	@class ARDWebSocketChannel;
	//@protocol ARDWebSocketChannelDelegate <NSObject>

	//- (void)channel:(ARDWebSocketChannel *)channel
	//    didChangeState:(ARDWebSocketChannelState)state;

	//- (void)channel:(ARDWebSocketChannel *)channel
	//    didReceiveMessage:(ARDSignalingMessage *)message;

	//@end
}