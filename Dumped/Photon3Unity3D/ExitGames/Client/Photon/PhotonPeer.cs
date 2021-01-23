/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExitGames.Client.Photon.EncryptorManaged;

// Image 42: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.1.2, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon
{
	public class PhotonPeer
	{
		// Fields
		public const bool NoSocket = false;
		public const bool NativeDatagramEncrypt = false;
		public const bool DebugBuild = true;
		protected internal byte ClientSdkId;
		public static bool AsyncKeyExchange;
		private string clientVersion;
		public Dictionary<ConnectionProtocol, Type> SocketImplementationConfig;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private Type _SocketImplementation_k__BackingField;
		public DebugLevel DebugOut;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private IPhotonPeerListener _Listener_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private TrafficStats _TrafficStatsIncoming_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private TrafficStats _TrafficStatsOutgoing_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private TrafficStatsGameLevel _TrafficStatsGameLevel_k__BackingField;
		private Stopwatch trafficStatsStopwatch;
		private bool trafficStatsEnabled;
		private int commandLogSize;
		private byte quickResendAttempts;
		public int RhttpMinConnections;
		public int RhttpMaxConnections;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private int _LimitOfUnreliableCommands_k__BackingField;
		public byte ChannelCount;
		private bool crcEnabled;
		public int SentCountAllowance;
		public int TimePingInterval;
		public int DisconnectTimeout;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private ConnectionProtocol _TransportProtocol_k__BackingField;
		public static int OutgoingStreamBufferSize;
		private int mtu;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private bool _IsSendingOnlyAcks_k__BackingField;
		internal PeerBase peerBase;
		private readonly object SendOutgoingLockObject;
		private readonly object DispatchLockObject;
		private readonly object EnqueueLock;
		protected internal byte[] PayloadEncryptionSecret;
		internal Encryptor encryptor;
		internal Decryptor decryptor;
	
		// Properties
		protected internal byte ClientSdkIdShifted { get; }
		public string ClientVersion { get; }
		public Type SocketImplementation { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public IPhotonPeerListener Listener { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public long BytesIn { get; }
		public long BytesOut { get; }
		public TrafficStats TrafficStatsIncoming { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public TrafficStats TrafficStatsOutgoing { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public TrafficStatsGameLevel TrafficStatsGameLevel { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public bool TrafficStatsEnabled { get; }
		public int CommandLogSize { get; }
		public byte QuickResendAttempts { get; set; }
		public PeerStateValue PeerState { get; }
		public int LimitOfUnreliableCommands { [CompilerGenerated] get; }
		public int QueuedIncomingCommands { get; }
		public int QueuedOutgoingCommands { get; }
		public bool CrcEnabled { get; set; }
		public int RoundTripTime { get; }
		public int RoundTripTimeVariance { get; }
		public string ServerAddress { get; }
		public ConnectionProtocol TransportProtocol { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int MaximumTransferUnit { get; set; }
		public bool IsEncryptionAvailable { get; }
		public bool IsSendingOnlyAcks { [CompilerGenerated] get; }
	
		// Constructors
		public PhotonPeer(ConnectionProtocol protocolType);
		static PhotonPeer();
	
		// Methods
		internal void InitializeTrafficStats();
		public virtual bool Connect(string serverAddress, string applicationName, object custom);
		private void CreatePeerBase();
		public virtual void Disconnect();
		public bool EstablishEncryption();
		public bool InitDatagramEncryption(byte[] encryptionSecret, byte[] hmacSecret);
		public void InitPayloadEncryption(byte[] secret);
		public virtual void Service();
		public virtual bool SendOutgoingCommands();
		public virtual bool SendAcksOnly();
		public virtual bool DispatchIncomingCommands();
		public virtual bool OpCustom(byte customOpCode, Dictionary<byte, object> customOpParameters, bool sendReliable);
		public virtual bool OpCustom(byte customOpCode, Dictionary<byte, object> customOpParameters, bool sendReliable, byte channelId);
		public virtual bool OpCustom(byte customOpCode, Dictionary<byte, object> customOpParameters, bool sendReliable, byte channelId, bool encrypt);
		[CompilerGenerated]
		private bool _EstablishEncryption_b__148_0();
	}
}
