/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExitGames.Client;
using Photon.SocketServer.Security;

// Image 42: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.1.2, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon
{
	public abstract class PeerBase
	{
		// Fields
		internal PhotonPeer ppeer;
		internal IProtocol protocol;
		internal ConnectionProtocol usedProtocol;
		internal IPhotonSocket rt;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private string _ServerAddress_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private string _HttpUrlParameters_k__BackingField;
		internal int ByteCountLastOperation;
		internal int ByteCountCurrentDispatch;
		internal NCommand CommandInCurrentDispatch;
		internal int TrafficPackageHeaderSize;
		internal int packetLossByCrc;
		internal int packetLossByChallenge;
		internal readonly Queue<MyAction> ActionQueue;
		internal short peerID;
		internal ConnectionStateValue peerConnectionState;
		internal int serverTimeOffset;
		internal bool serverTimeOffsetIsAvailable;
		internal int roundTripTime;
		internal int roundTripTimeVariance;
		internal int lastRoundTripTime;
		internal int lowestRoundTripTime;
		internal int lastRoundTripTimeVariance;
		internal int highestRoundTripTimeVariance;
		internal int timestampOfLastReceive;
		internal int packetThrottleInterval;
		internal static short peerCount;
		internal long bytesOut;
		internal long bytesIn;
		internal int commandBufferSize;
		internal int warningSize;
		internal ICryptoProvider CryptoProvider;
		private readonly Random lagRandomizer;
		internal readonly LinkedList<SimulationItem> NetSimListOutgoing;
		internal readonly LinkedList<SimulationItem> NetSimListIncoming;
		private readonly NetworkSimulationSet networkSimulationSettings;
		internal Queue<CmdLogItem> CommandLog;
		internal Queue<CmdLogItem> InReliableLog;
		internal object CustomInitData;
		internal string AppId;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private byte[] _TcpConnectionPrefix_k__BackingField;
		internal int timeBase;
		internal int timeInt;
		internal int timeoutInt;
		internal int timeLastAckReceive;
		internal int timeLastSendAck;
		internal int timeLastSendOutgoing;
		internal const int ENET_PEER_PACKET_LOSS_SCALE = 65536;
		internal const int ENET_PEER_DEFAULT_ROUND_TRIP_TIME = 300;
		internal const int ENET_PEER_PACKET_THROTTLE_INTERVAL = 5000;
		internal bool ApplicationIsInitialized;
		internal bool isEncryptionAvailable;
		internal int outgoingCommandsInStream;
		protected StreamBuffer SerializeMemStream;
	
		// Properties
		internal string ClientVersion { get; }
		internal Type SocketImplementation { get; }
		public string ServerAddress { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		internal bool TrafficStatsEnabled { get; }
		internal TrafficStats TrafficStatsIncoming { get; }
		internal TrafficStats TrafficStatsOutgoing { get; }
		internal TrafficStatsGameLevel TrafficStatsGameLevel { get; }
		internal bool crcEnabled { get; }
		internal IPhotonPeerListener Listener { get; }
		internal DebugLevel debugOut { get; }
		internal int sentCountAllowance { get; }
		internal int DisconnectTimeout { get; }
		internal int timePingInterval { get; }
		internal byte ChannelCount { get; }
		internal int limitOfUnreliableCommands { get; }
		public byte QuickResendAttempts { get; }
		public NetworkSimulationSet NetworkSimulationSettings { get; }
		internal int CommandLogSize { get; }
		internal long BytesOut { get; }
		internal long BytesIn { get; }
		internal abstract int QueuedIncomingCommandsCount { get; }
		internal abstract int QueuedOutgoingCommandsCount { get; }
		protected internal bool IsIpv6 { get; }
		internal bool IsSendingOnlyAcks { get; }
		internal int mtu { get; }
	
		// Nested types
		internal delegate void MyAction();
	
		public enum ConnectionStateValue : byte
		{
			Disconnected = 0,
			Connecting = 1,
			Connected = 3,
			Disconnecting = 4,
			AcknowledgingDisconnect = 5,
			Zombie = 6
		}
	
		internal enum EgMessageType : byte
		{
			Init = 0,
			InitResponse = 1,
			Operation = 2,
			OperationResponse = 3,
			Event = 4,
			InternalOperationRequest = 6,
			InternalOperationResponse = 7,
			Message = 8,
			RawMessage = 9
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass147_0
		{
			// Fields
			public DebugLevel level;
			public string debugReturn;
			public PeerBase __4__this;
	
			// Constructors
			public __c__DisplayClass147_0();
	
			// Methods
			internal void _EnqueueDebugReturn_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass148_0
		{
			// Fields
			public StatusCode statusValue;
			public PeerBase __4__this;
	
			// Constructors
			public __c__DisplayClass148_0();
	
			// Methods
			internal void _EnqueueStatusCallback_b__0();
		}
	
		// Constructors
		protected PeerBase();
	
		// Methods
		internal void CommandLogResize();
		internal void CommandLogInit();
		internal void InitOnce();
		internal abstract bool Connect(string serverAddress, string appID, object customData = null);
		public abstract void OnConnect();
		private string GetHttpKeyValueString(Dictionary<string, string> dic);
		internal byte[] PrepareConnectData(string serverAddress, string appID, object custom);
		internal string PepareWebSocketUrl(string serverAddress, string appId, object customData);
		internal abstract void Disconnect();
		internal abstract void StopConnection();
		internal abstract void FetchServerTimestamp();
		internal bool EnqueueOperation(Dictionary<byte, object> parameters, byte opCode, bool sendReliable, byte channelId, bool encrypted);
		internal abstract bool EnqueueOperation(Dictionary<byte, object> parameters, byte opCode, bool sendReliable, byte channelId, bool encrypted, EgMessageType messageType);
		internal abstract bool DispatchIncomingCommands();
		internal abstract bool SendOutgoingCommands();
		internal virtual bool SendAcksOnly();
		internal abstract byte[] SerializeOperationToMessage(byte opCode, Dictionary<byte, object> parameters, EgMessageType messageType, bool encrypt);
		internal abstract void ReceiveIncomingCommands(byte[] inBuff, int dataLength);
		internal void InitCallback();
		internal bool ExchangeKeysForEncryption(object lockObject);
		internal void DeriveSharedKey(OperationResponse operationResponse);
		internal void EnqueueActionForDispatch(MyAction action);
		internal void EnqueueDebugReturn(DebugLevel level, string debugReturn);
		internal void EnqueueStatusCallback(StatusCode statusValue);
		internal virtual void InitPeerBase();
		internal virtual bool DeserializeMessageAndCallback(byte[] inBuff);
		internal void SendNetworkSimulated(MyAction sendAction);
		internal void ReceiveNetworkSimulated(MyAction receiveAction);
		protected internal void NetworkSimRun();
		internal void UpdateRoundTripTimeAndVariance(int lastRoundtripTime);
		internal virtual void InitEncryption(byte[] secret);
	}
}
