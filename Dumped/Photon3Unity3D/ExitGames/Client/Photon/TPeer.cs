/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 42: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.1.2, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon
{
	internal class TPeer : PeerBase
	{
		// Fields
		private Queue<byte[]> incomingList;
		internal List<byte[]> outgoingStream;
		private int lastPingResult;
		private byte[] pingRequest;
		internal static readonly byte[] tcpFramedMessageHead;
		internal static readonly byte[] tcpMsgHead;
		internal byte[] messageHeader;
		protected internal bool DoFraming;
	
		// Properties
		internal override int QueuedIncomingCommandsCount { get; }
		internal override int QueuedOutgoingCommandsCount { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public byte[] data;
			public TPeer __4__this;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal void _SendData_b__0();
		}
	
		// Constructors
		internal TPeer();
		static TPeer();
	
		// Methods
		internal override void InitPeerBase();
		internal override bool Connect(string serverAddress, string appID, object customData = null);
		public override void OnConnect();
		internal override void Disconnect();
		internal override void StopConnection();
		internal override void FetchServerTimestamp();
		private void EnqueueInit(byte[] data);
		internal override bool DispatchIncomingCommands();
		internal override bool SendOutgoingCommands();
		internal override bool SendAcksOnly();
		internal override bool EnqueueOperation(Dictionary<byte, object> parameters, byte opCode, bool sendReliable, byte channelId, bool encrypt, EgMessageType messageType);
		internal override byte[] SerializeOperationToMessage(byte opc, Dictionary<byte, object> parameters, EgMessageType messageType, bool encrypt);
		internal bool EnqueueMessageAsPayload(bool sendReliable, byte[] opMessage, byte channelId);
		internal void SendPing();
		internal void SendData(byte[] data);
		internal override void ReceiveIncomingCommands(byte[] inbuff, int dataLength);
		private void ReadPingResult(byte[] inbuff);
		protected internal void ReadPingResult(OperationResponse operationResponse);
	}
}
