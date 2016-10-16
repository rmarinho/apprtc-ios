using System;
using ObjCRuntime;

public enum RTCICEConnectionState : uint
{
	New,
	Checking,
	Connected,
	Completed,
	Failed,
	Disconnected,
	Closed,
	Max
}

public enum RTCICEGatheringState : uint
{
	New,
	Gathering,
	Complete
}

public enum RTCSignalingState : uint
{
	Stable,
	HaveLocalOffer,
	HaveLocalPrAnswer,
	HaveRemoteOffer,
	HaveRemotePrAnswer,
	Closed
}

public enum RTCStatsOutputLevel : uint
{
	Standard,
	Debug
}

public enum RTCSourceState : uint
{
	Initializing,
	Live,
	Ended,
	Muted
}

public enum RTCTrackState : uint
{
	Initializing,
	Live,
	Ended,
	Failed
}

[Native]
public enum ARDAppClientState : nint
{
	Disconnected,
	Connecting,
	Connected
}

[Native]
public enum ARDMessageResultType : nint
{
	Unknown,
	Success,
	InvalidRoom,
	InvalidClient
}

[Native]
public enum ARDRegisterResultType : nint
{
	Unknown,
	Success,
	Full
}

public enum ARDSignalingMessageType : uint
{
	Candidate,
	Offer,
	Answer,
	Bye
}

[Native]
public enum ARDWebSocketChannelState : nint
{
	Closed,
	Open,
	Registered,
	Error
}

[Native]
public enum SRReadyState : nint
{
	Connecting = 0,
	Open = 1,
	Closing = 2,
	Closed = 3
}

[Native]
public enum SRStatusCode : nint
{
	CodeNormal = 1000,
	CodeGoingAway = 1001,
	CodeProtocolError = 1002,
	CodeUnhandledType = 1003,
	NoStatusReceived = 1005,
	CodeInvalidUTF8 = 1007,
	CodePolicyViolated = 1008,
	CodeMessageTooBig = 1009
}

[Native]
public enum RTCIceTransportsType : nint
{
	None,
	Relay,
	NoHost,
	All
}

[Native]
public enum RTCBundlePolicy : nint
{
	Balanced,
	MaxBundle,
	MaxCompat
}

[Native]
public enum RTCRtcpMuxPolicy : nint
{
	Negotiate,
	Require
}

[Native]
public enum RTCTcpCandidatePolicy : nint
{
	Enabled,
	Disabled
}

public enum RTCDataChannelState : uint
{
	Connecting,
	Open,
	Closing,
	Closed
}
