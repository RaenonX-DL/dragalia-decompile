/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 44: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.1.2, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon
{
	public abstract class IPhotonSocket
	{
		// Fields
		protected internal PeerBase peerBase;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private ConnectionProtocol _Protocol_k__BackingField;
		public bool PollReceive;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private PhotonSocketState _State_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private string _ServerAddress_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private int _ServerPort_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private bool _AddressResolvedAsIpv6_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private string _UrlProtocol_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private string _UrlPath_k__BackingField;
	
		// Properties
		protected IPhotonPeerListener Listener { get; }
		public ConnectionProtocol Protocol { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public PhotonSocketState State { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public string ServerAddress { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public int ServerPort { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public bool AddressResolvedAsIpv6 { [CompilerGenerated] get; [CompilerGenerated] protected internal set; }
		protected string UrlProtocol { [CompilerGenerated] set; }
		protected string UrlPath { [CompilerGenerated] set; }
		public bool Connected { get; }
		protected internal int MTU { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0
		{
			// Fields
			public byte[] inBufferCopy;
			public __c__DisplayClass41_1 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass41_0();
	
			// Methods
			internal void _HandleReceivedDatagram_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_1
		{
			// Fields
			public int length;
			public byte[] inBuffer;
			public IPhotonSocket __4__this;
	
			// Constructors
			public __c__DisplayClass41_1();
	
			// Methods
			internal void _HandleReceivedDatagram_b__1();
		}
	
		// Constructors
		public IPhotonSocket(PeerBase peerBase);
	
		// Methods
		public virtual bool Connect();
		public abstract bool Disconnect();
		public abstract PhotonSocketError Send(byte[] data, int length);
		public void HandleReceivedDatagram(byte[] inBuffer, int length, bool willBeReused);
		public bool ReportDebugOfLevel(DebugLevel levelOfMessage);
		public void EnqueueDebugReturn(DebugLevel debugLevel, string message);
		protected internal void HandleException(StatusCode statusCode);
		protected internal bool TryParseAddress(string url, out string address, out ushort port, out string urlProtocol, out string urlPath);
		protected internal bool IsIpv6SimpleCheck(IPAddress address);
		protected internal static IPAddress GetIpAddress(string address);
		[CompilerGenerated]
		private void _HandleException_b__44_0();
	}
}
