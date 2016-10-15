using System;
using System.Runtime.InteropServices;
using Foundation;
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

public enum RTCDataChannelState : uint
{
	Connecting,
	Open,
	Closing,
	Closed
}

[Native]
public enum RTCFileLoggerSeverity : nuint
{
	Verbose,
	Info,
	Warning,
	Error
}

[Native]
public enum RTCFileLoggerRotationType : nuint
{
	Call,
	App
}

[Native]
public enum RTCLoggingSeverity : nint
{
	Verbose,
	Info,
	Warning,
	Error
}

static class CFunctions
{
	// extern void RTCLogEx (RTCLoggingSeverity severity, NSString *logString);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern void RTCLogEx (RTCLoggingSeverity severity, NSString logString);

	// extern void RTCSetMinDebugLogLevel (RTCLoggingSeverity severity);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern void RTCSetMinDebugLogLevel (RTCLoggingSeverity severity);

	// extern NSString * RTCFileName (const char *filePath);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe NSString RTCFileName (sbyte* filePath);
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
