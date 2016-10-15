using System;
using CFNetwork;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

// @protocol RTCMediaStreamTrackDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface RTCMediaStreamTrackDelegate
{
	// @required -(void)mediaStreamTrackDidChange:(RTCMediaStreamTrack *)mediaStreamTrack;
	[Abstract]
	[Export ("mediaStreamTrackDidChange:")]
	void MediaStreamTrackDidChange (RTCMediaStreamTrack mediaStreamTrack);
}

// @interface RTCMediaStreamTrack : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RTCMediaStreamTrack
{
	// @property (readonly, nonatomic) NSString * kind;
	[Export ("kind")]
	string Kind { get; }

	// @property (readonly, nonatomic) NSString * label;
	[Export ("label")]
	string Label { get; }

	[Wrap ("WeakDelegate")]
	RTCMediaStreamTrackDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<RTCMediaStreamTrackDelegate> delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// -(BOOL)isEnabled;
	[Export ("isEnabled")]
	[Verify (MethodToProperty)]
	bool IsEnabled { get; }

	// -(BOOL)setEnabled:(BOOL)enabled;
	[Export ("setEnabled:")]
	bool SetEnabled (bool enabled);

	// -(RTCTrackState)state;
	[Export ("state")]
	[Verify (MethodToProperty)]
	RTCTrackState State { get; }

	// -(BOOL)setState:(RTCTrackState)state;
	[Export ("setState:")]
	bool SetState (RTCTrackState state);
}

// @interface RTCVideoTrack : RTCMediaStreamTrack
[BaseType (typeof(RTCMediaStreamTrack))]
[DisableDefaultCtor]
interface RTCVideoTrack
{
	// @property (readonly, nonatomic) RTCVideoSource * source;
	[Export ("source")]
	RTCVideoSource Source { get; }

	// -(instancetype)initWithFactory:(RTCPeerConnectionFactory *)factory source:(RTCVideoSource *)source trackId:(NSString *)trackId;
	[Export ("initWithFactory:source:trackId:")]
	IntPtr Constructor (RTCPeerConnectionFactory factory, RTCVideoSource source, string trackId);

	// -(void)addRenderer:(id<RTCVideoRenderer>)renderer;
	[Export ("addRenderer:")]
	void AddRenderer (RTCVideoRenderer renderer);

	// -(void)removeRenderer:(id<RTCVideoRenderer>)renderer;
	[Export ("removeRenderer:")]
	void RemoveRenderer (RTCVideoRenderer renderer);
}

// @protocol ARDAppClientDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface ARDAppClientDelegate
{
	// @required -(void)appClient:(ARDAppClient *)client didChangeState:(ARDAppClientState)state;
	[Abstract]
	[Export ("appClient:didChangeState:")]
	void DidChangeState (ARDAppClient client, ARDAppClientState state);

	// @required -(void)appClient:(ARDAppClient *)client didReceiveLocalVideoTrack:(RTCVideoTrack *)localVideoTrack;
	[Abstract]
	[Export ("appClient:didReceiveLocalVideoTrack:")]
	void DidReceiveLocalVideoTrack (ARDAppClient client, RTCVideoTrack localVideoTrack);

	// @required -(void)appClient:(ARDAppClient *)client didReceiveRemoteVideoTrack:(RTCVideoTrack *)remoteVideoTrack;
	[Abstract]
	[Export ("appClient:didReceiveRemoteVideoTrack:")]
	void DidReceiveRemoteVideoTrack (ARDAppClient client, RTCVideoTrack remoteVideoTrack);

	// @required -(void)appClient:(ARDAppClient *)client didError:(NSError *)error;
	[Abstract]
	[Export ("appClient:didError:")]
	void DidError (ARDAppClient client, NSError error);
}

// @interface ARDAppClient : NSObject
[BaseType (typeof(NSObject))]
interface ARDAppClient
{
	// @property (readonly, nonatomic) ARDAppClientState state;
	[Export ("state")]
	ARDAppClientState State { get; }

	[Wrap ("WeakDelegate")]
	ARDAppClientDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<ARDAppClientDelegate> delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// @property (nonatomic, strong) NSString * serverHostUrl;
	[Export ("serverHostUrl", ArgumentSemantic.Strong)]
	string ServerHostUrl { get; set; }

	// -(instancetype)initWithDelegate:(id<ARDAppClientDelegate>)delegate;
	[Export ("initWithDelegate:")]
	IntPtr Constructor (ARDAppClientDelegate @delegate);

	// -(void)connectToRoomWithId:(NSString *)roomId options:(NSDictionary *)options;
	[Export ("connectToRoomWithId:options:")]
	void ConnectToRoomWithId (string roomId, NSDictionary options);

	// -(void)muteAudioIn;
	[Export ("muteAudioIn")]
	void MuteAudioIn ();

	// -(void)unmuteAudioIn;
	[Export ("unmuteAudioIn")]
	void UnmuteAudioIn ();

	// -(void)muteVideoIn;
	[Export ("muteVideoIn")]
	void MuteVideoIn ();

	// -(void)unmuteVideoIn;
	[Export ("unmuteVideoIn")]
	void UnmuteVideoIn ();

	// -(void)enableSpeaker;
	[Export ("enableSpeaker")]
	void EnableSpeaker ();

	// -(void)disableSpeaker;
	[Export ("disableSpeaker")]
	void DisableSpeaker ();

	// -(void)swapCameraToFront;
	[Export ("swapCameraToFront")]
	void SwapCameraToFront ();

	// -(void)swapCameraToBack;
	[Export ("swapCameraToBack")]
	void SwapCameraToBack ();

	// -(void)disconnect;
	[Export ("disconnect")]
	void Disconnect ();
}

// @interface ARDMessageResponse : NSObject
[BaseType (typeof(NSObject))]
interface ARDMessageResponse
{
	// @property (readonly, nonatomic) ARDMessageResultType result;
	[Export ("result")]
	ARDMessageResultType Result { get; }

	// +(ARDMessageResponse *)responseFromJSONData:(NSData *)data;
	[Static]
	[Export ("responseFromJSONData:")]
	ARDMessageResponse ResponseFromJSONData (NSData data);
}

// @interface ARDRegisterResponse : NSObject
[BaseType (typeof(NSObject))]
interface ARDRegisterResponse
{
	// @property (readonly, nonatomic) ARDRegisterResultType result;
	[Export ("result")]
	ARDRegisterResultType Result { get; }

	// @property (readonly, nonatomic) BOOL isInitiator;
	[Export ("isInitiator")]
	bool IsInitiator { get; }

	// @property (readonly, nonatomic) NSString * roomId;
	[Export ("roomId")]
	string RoomId { get; }

	// @property (readonly, nonatomic) NSString * clientId;
	[Export ("clientId")]
	string ClientId { get; }

	// @property (readonly, nonatomic) NSArray * messages;
	[Export ("messages")]
	[Verify (StronglyTypedNSArray)]
	NSObject[] Messages { get; }

	// @property (readonly, nonatomic) NSURL * webSocketURL;
	[Export ("webSocketURL")]
	NSUrl WebSocketURL { get; }

	// @property (readonly, nonatomic) NSURL * webSocketRestURL;
	[Export ("webSocketRestURL")]
	NSUrl WebSocketRestURL { get; }

	// +(ARDRegisterResponse *)responseFromJSONData:(NSData *)data;
	[Static]
	[Export ("responseFromJSONData:")]
	ARDRegisterResponse ResponseFromJSONData (NSData data);
}

// @interface RTCICECandidate : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RTCICECandidate
{
	// @property (readonly, copy, nonatomic) NSString * sdpMid;
	[Export ("sdpMid")]
	string SdpMid { get; }

	// @property (readonly, assign, nonatomic) NSInteger sdpMLineIndex;
	[Export ("sdpMLineIndex")]
	nint SdpMLineIndex { get; }

	// @property (readonly, copy, nonatomic) NSString * sdp;
	[Export ("sdp")]
	string Sdp { get; }

	// -(id)initWithMid:(NSString *)sdpMid index:(NSInteger)sdpMLineIndex sdp:(NSString *)sdp;
	[Export ("initWithMid:index:sdp:")]
	IntPtr Constructor (string sdpMid, nint sdpMLineIndex, string sdp);
}

// @interface RTCSessionDescription : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RTCSessionDescription
{
	// @property (readonly, copy, nonatomic) NSString * description;
	[Export ("description")]
	string Description { get; }

	// @property (readonly, copy, nonatomic) NSString * type;
	[Export ("type")]
	string Type { get; }

	// -(id)initWithType:(NSString *)type sdp:(NSString *)sdp;
	[Export ("initWithType:sdp:")]
	IntPtr Constructor (string type, string sdp);
}

// @interface ARDSignalingMessage : NSObject
[BaseType (typeof(NSObject))]
interface ARDSignalingMessage
{
	// @property (readonly, nonatomic) ARDSignalingMessageType type;
	[Export ("type")]
	ARDSignalingMessageType Type { get; }

	// +(ARDSignalingMessage *)messageFromJSONString:(NSString *)jsonString;
	[Static]
	[Export ("messageFromJSONString:")]
	ARDSignalingMessage MessageFromJSONString (string jsonString);

	// -(NSData *)JSONData;
	[Export ("JSONData")]
	[Verify (MethodToProperty)]
	NSData JSONData { get; }
}

// @interface ARDICECandidateMessage : ARDSignalingMessage
[BaseType (typeof(ARDSignalingMessage))]
interface ARDICECandidateMessage
{
	// @property (readonly, nonatomic) RTCICECandidate * candidate;
	[Export ("candidate")]
	RTCICECandidate Candidate { get; }

	// -(instancetype)initWithCandidate:(RTCICECandidate *)candidate;
	[Export ("initWithCandidate:")]
	IntPtr Constructor (RTCICECandidate candidate);
}

// @interface ARDSessionDescriptionMessage : ARDSignalingMessage
[BaseType (typeof(ARDSignalingMessage))]
interface ARDSessionDescriptionMessage
{
	// @property (readonly, nonatomic) RTCSessionDescription * sessionDescription;
	[Export ("sessionDescription")]
	RTCSessionDescription SessionDescription { get; }

	// -(instancetype)initWithDescription:(RTCSessionDescription *)description;
	[Export ("initWithDescription:")]
	IntPtr Constructor (RTCSessionDescription description);
}

// @interface ARDByeMessage : ARDSignalingMessage
[BaseType (typeof(ARDSignalingMessage))]
interface ARDByeMessage
{
}

// @interface ARDUtilites (NSDictionary)
[Category]
[BaseType (typeof(NSDictionary))]
interface NSDictionary_ARDUtilites
{
	// +(NSDictionary *)dictionaryWithJSONString:(NSString *)jsonString;
	[Static]
	[Export ("dictionaryWithJSONString:")]
	NSDictionary DictionaryWithJSONString (string jsonString);

	// +(NSDictionary *)dictionaryWithJSONData:(NSData *)jsonData;
	[Static]
	[Export ("dictionaryWithJSONData:")]
	NSDictionary DictionaryWithJSONData (NSData jsonData);
}

// @interface ARDUtilities (NSURLConnection)
[Category]
[BaseType (typeof(NSUrlConnection))]
interface NSURLConnection_ARDUtilities
{
	// +(void)sendAsyncRequest:(NSURLRequest *)request completionHandler:(void (^)(NSURLResponse *, NSData *, NSError *))completionHandler;
	[Static]
	[Export ("sendAsyncRequest:completionHandler:")]
	void SendAsyncRequest (NSUrlRequest request, Action<NSURLResponse, NSData, NSError> completionHandler);

	// +(void)sendAsyncPostToURL:(NSURL *)url withData:(NSData *)data completionHandler:(void (^)(BOOL, NSData *))completionHandler;
	[Static]
	[Export ("sendAsyncPostToURL:withData:completionHandler:")]
	void SendAsyncPostToURL (NSUrl url, NSData data, Action<bool, NSData> completionHandler);
}

// @protocol ARDWebSocketChannelDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface ARDWebSocketChannelDelegate
{
	// @required -(void)channel:(ARDWebSocketChannel *)channel didChangeState:(ARDWebSocketChannelState)state;
	[Abstract]
	[Export ("channel:didChangeState:")]
	void DidChangeState (ARDWebSocketChannel channel, ARDWebSocketChannelState state);

	// @required -(void)channel:(ARDWebSocketChannel *)channel didReceiveMessage:(ARDSignalingMessage *)message;
	[Abstract]
	[Export ("channel:didReceiveMessage:")]
	void DidReceiveMessage (ARDWebSocketChannel channel, ARDSignalingMessage message);
}

// @interface ARDWebSocketChannel : NSObject
[BaseType (typeof(NSObject))]
interface ARDWebSocketChannel
{
	// @property (readonly, nonatomic) NSString * roomId;
	[Export ("roomId")]
	string RoomId { get; }

	// @property (readonly, nonatomic) NSString * clientId;
	[Export ("clientId")]
	string ClientId { get; }

	// @property (readonly, nonatomic) ARDWebSocketChannelState state;
	[Export ("state")]
	ARDWebSocketChannelState State { get; }

	[Wrap ("WeakDelegate")]
	ARDWebSocketChannelDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<ARDWebSocketChannelDelegate> delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// -(instancetype)initWithURL:(NSURL *)url restURL:(NSURL *)restURL delegate:(id<ARDWebSocketChannelDelegate>)delegate;
	[Export ("initWithURL:restURL:delegate:")]
	IntPtr Constructor (NSUrl url, NSUrl restURL, ARDWebSocketChannelDelegate @delegate);

	// -(void)registerForRoomId:(NSString *)roomId clientId:(NSString *)clientId;
	[Export ("registerForRoomId:clientId:")]
	void RegisterForRoomId (string roomId, string clientId);

	// -(void)sendData:(NSData *)data;
	[Export ("sendData:")]
	void SendData (NSData data);
}

// @interface JSON (RTCICECandidate)
[Category]
[BaseType (typeof(RTCICECandidate))]
interface RTCICECandidate_JSON
{
	// +(RTCICECandidate *)candidateFromJSONDictionary:(NSDictionary *)dictionary;
	[Static]
	[Export ("candidateFromJSONDictionary:")]
	RTCICECandidate CandidateFromJSONDictionary (NSDictionary dictionary);

	// -(NSData *)JSONData;
	[Export ("JSONData")]
	[Verify (MethodToProperty)]
	NSData JSONData { get; }
}

// @interface RTCICEServer : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RTCICEServer
{
	// @property (readonly, nonatomic, strong) NSURL * URI;
	[Export ("URI", ArgumentSemantic.Strong)]
	NSUrl URI { get; }

	// @property (readonly, copy, nonatomic) NSString * username;
	[Export ("username")]
	string Username { get; }

	// @property (readonly, copy, nonatomic) NSString * password;
	[Export ("password")]
	string Password { get; }

	// -(id)initWithURI:(NSURL *)URI username:(NSString *)username password:(NSString *)password;
	[Export ("initWithURI:username:password:")]
	IntPtr Constructor (NSUrl URI, string username, string password);
}

// @interface JSON (RTCICEServer)
[Category]
[BaseType (typeof(RTCICEServer))]
interface RTCICEServer_JSON
{
	// +(RTCICEServer *)serverFromJSONDictionary:(NSDictionary *)dictionary;
	[Static]
	[Export ("serverFromJSONDictionary:")]
	RTCICEServer ServerFromJSONDictionary (NSDictionary dictionary);

	// +(NSArray *)serversFromCEODJSONDictionary:(NSDictionary *)dictionary;
	[Static]
	[Export ("serversFromCEODJSONDictionary:")]
	[Verify (StronglyTypedNSArray)]
	NSObject[] ServersFromCEODJSONDictionary (NSDictionary dictionary);
}

// @interface RTCMediaConstraints : NSObject
[BaseType (typeof(NSObject))]
interface RTCMediaConstraints
{
	// -(id)initWithMandatoryConstraints:(NSArray *)mandatory optionalConstraints:(NSArray *)optional;
	[Export ("initWithMandatoryConstraints:optionalConstraints:")]
	[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
	IntPtr Constructor (NSObject[] mandatory, NSObject[] optional);
}

// @interface JSON (RTCMediaConstraints)
[Category]
[BaseType (typeof(RTCMediaConstraints))]
interface RTCMediaConstraints_JSON
{
	// +(RTCMediaConstraints *)constraintsFromJSONDictionary:(NSDictionary *)dictionary;
	[Static]
	[Export ("constraintsFromJSONDictionary:")]
	RTCMediaConstraints ConstraintsFromJSONDictionary (NSDictionary dictionary);
}

// @interface JSON (RTCSessionDescription)
[Category]
[BaseType (typeof(RTCSessionDescription))]
interface RTCSessionDescription_JSON
{
	// +(RTCSessionDescription *)descriptionFromJSONDictionary:(NSDictionary *)dictionary;
	[Static]
	[Export ("descriptionFromJSONDictionary:")]
	RTCSessionDescription DescriptionFromJSONDictionary (NSDictionary dictionary);

	// -(NSData *)JSONData;
	[Export ("JSONData")]
	[Verify (MethodToProperty)]
	NSData JSONData { get; }
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern NSString *const SRWebSocketErrorDomain;
	[Field ("SRWebSocketErrorDomain", "__Internal")]
	NSString SRWebSocketErrorDomain { get; }

	// extern NSString *const SRHTTPResponseErrorKey;
	[Field ("SRHTTPResponseErrorKey", "__Internal")]
	NSString SRHTTPResponseErrorKey { get; }
}

// @interface SRWebSocket : NSObject <NSStreamDelegate>
[BaseType (typeof(NSObject))]
interface SRWebSocket : INSStreamDelegate
{
	[Wrap ("WeakDelegate")]
	SRWebSocketDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<SRWebSocketDelegate> delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// @property (readonly, nonatomic) SRReadyState readyState;
	[Export ("readyState")]
	SRReadyState ReadyState { get; }

	// @property (readonly, retain, nonatomic) NSURL * url;
	[Export ("url", ArgumentSemantic.Retain)]
	NSUrl Url { get; }

	// @property (readonly, nonatomic) CFHTTPMessageRef receivedHTTPHeaders;
	[Export ("receivedHTTPHeaders")]
	unsafe CFHTTPMessageRef* ReceivedHTTPHeaders { get; }

	// @property (readwrite, nonatomic) NSArray * requestCookies;
	[Export ("requestCookies", ArgumentSemantic.Assign)]
	[Verify (StronglyTypedNSArray)]
	NSObject[] RequestCookies { get; set; }

	// @property (readonly, copy, nonatomic) NSString * protocol;
	[Export ("protocol")]
	string Protocol { get; }

	// -(id)initWithURLRequest:(NSURLRequest *)request protocols:(NSArray *)protocols allowsUntrustedSSLCertificates:(BOOL)allowsUntrustedSSLCertificates;
	[Export ("initWithURLRequest:protocols:allowsUntrustedSSLCertificates:")]
	[Verify (StronglyTypedNSArray)]
	IntPtr Constructor (NSUrlRequest request, NSObject[] protocols, bool allowsUntrustedSSLCertificates);

	// -(id)initWithURLRequest:(NSURLRequest *)request protocols:(NSArray *)protocols;
	[Export ("initWithURLRequest:protocols:")]
	[Verify (StronglyTypedNSArray)]
	IntPtr Constructor (NSUrlRequest request, NSObject[] protocols);

	// -(id)initWithURLRequest:(NSURLRequest *)request;
	[Export ("initWithURLRequest:")]
	IntPtr Constructor (NSUrlRequest request);

	// -(id)initWithURL:(NSURL *)url protocols:(NSArray *)protocols allowsUntrustedSSLCertificates:(BOOL)allowsUntrustedSSLCertificates;
	[Export ("initWithURL:protocols:allowsUntrustedSSLCertificates:")]
	[Verify (StronglyTypedNSArray)]
	IntPtr Constructor (NSUrl url, NSObject[] protocols, bool allowsUntrustedSSLCertificates);

	// -(id)initWithURL:(NSURL *)url protocols:(NSArray *)protocols;
	[Export ("initWithURL:protocols:")]
	[Verify (StronglyTypedNSArray)]
	IntPtr Constructor (NSUrl url, NSObject[] protocols);

	// -(id)initWithURL:(NSURL *)url;
	[Export ("initWithURL:")]
	IntPtr Constructor (NSUrl url);

	// -(void)setDelegateOperationQueue:(NSOperationQueue *)queue;
	[Export ("setDelegateOperationQueue:")]
	void SetDelegateOperationQueue (NSOperationQueue queue);

	// -(void)setDelegateDispatchQueue:(dispatch_queue_t)queue;
	[Export ("setDelegateDispatchQueue:")]
	void SetDelegateDispatchQueue (DispatchQueue queue);

	// -(void)scheduleInRunLoop:(NSRunLoop *)aRunLoop forMode:(NSString *)mode;
	[Export ("scheduleInRunLoop:forMode:")]
	void ScheduleInRunLoop (NSRunLoop aRunLoop, string mode);

	// -(void)unscheduleFromRunLoop:(NSRunLoop *)aRunLoop forMode:(NSString *)mode;
	[Export ("unscheduleFromRunLoop:forMode:")]
	void UnscheduleFromRunLoop (NSRunLoop aRunLoop, string mode);

	// -(void)open;
	[Export ("open")]
	void Open ();

	// -(void)close;
	[Export ("close")]
	void Close ();

	// -(void)closeWithCode:(NSInteger)code reason:(NSString *)reason;
	[Export ("closeWithCode:reason:")]
	void CloseWithCode (nint code, string reason);

	// -(void)send:(id)data;
	[Export ("send:")]
	void Send (NSObject data);

	// -(void)sendPing:(NSData *)data;
	[Export ("sendPing:")]
	void SendPing (NSData data);
}

// @protocol SRWebSocketDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface SRWebSocketDelegate
{
	// @required -(void)webSocket:(SRWebSocket *)webSocket didReceiveMessage:(id)message;
	[Abstract]
	[Export ("webSocket:didReceiveMessage:")]
	void WebSocket (SRWebSocket webSocket, NSObject message);

	// @optional -(void)webSocketDidOpen:(SRWebSocket *)webSocket;
	[Export ("webSocketDidOpen:")]
	void WebSocketDidOpen (SRWebSocket webSocket);

	// @optional -(void)webSocket:(SRWebSocket *)webSocket didFailWithError:(NSError *)error;
	[Export ("webSocket:didFailWithError:")]
	void WebSocket (SRWebSocket webSocket, NSError error);

	// @optional -(void)webSocket:(SRWebSocket *)webSocket didCloseWithCode:(NSInteger)code reason:(NSString *)reason wasClean:(BOOL)wasClean;
	[Export ("webSocket:didCloseWithCode:reason:wasClean:")]
	void WebSocket (SRWebSocket webSocket, nint code, string reason, bool wasClean);

	// @optional -(void)webSocket:(SRWebSocket *)webSocket didReceivePong:(NSData *)pongPayload;
	[Export ("webSocket:didReceivePong:")]
	void WebSocket (SRWebSocket webSocket, NSData pongPayload);
}

// @interface CertificateAdditions (NSURLRequest)
[Category]
[BaseType (typeof(NSUrlRequest))]
interface NSURLRequest_CertificateAdditions
{
	// @property (readonly, retain, nonatomic) NSArray * SR_SSLPinnedCertificates;
	[Export ("SR_SSLPinnedCertificates", ArgumentSemantic.Retain)]
	[Verify (StronglyTypedNSArray)]
	NSObject[] SR_SSLPinnedCertificates { get; }
}

// @interface CertificateAdditions (NSMutableURLRequest)
[Category]
[BaseType (typeof(NSMutableUrlRequest))]
interface NSMutableURLRequest_CertificateAdditions
{
	// @property (retain, nonatomic) NSArray * SR_SSLPinnedCertificates;
	[Export ("SR_SSLPinnedCertificates", ArgumentSemantic.Retain)]
	[Verify (StronglyTypedNSArray)]
	NSObject[] SR_SSLPinnedCertificates { get; set; }
}

// @interface SRWebSocket (NSRunLoop)
[Category]
[BaseType (typeof(NSRunLoop))]
interface NSRunLoop_SRWebSocket
{
	// +(NSRunLoop *)SR_networkRunLoop;
	[Static]
	[Export ("SR_networkRunLoop")]
	[Verify (MethodToProperty)]
	NSRunLoop SR_networkRunLoop { get; }
}
