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
	internal class EnetPeer : PeerBase
	{
		// Fields
		private static readonly int HMAC_SIZE;
		private static readonly int BLOCK_SIZE;
		private static readonly int IV_SIZE;
		private Dictionary<byte, EnetChannel> channels;
		private List<NCommand> sentReliableCommands;
		private Queue<NCommand> outgoingAcknowledgementsList;
		internal readonly int windowSize;
		private byte udpCommandCount;
		private byte[] udpBuffer;
		private int udpBufferIndex;
		private int udpBufferLength;
		private byte[] bufferForEncryption;
		internal int challenge;
		internal int reliableCommandsRepeated;
		internal int reliableCommandsSent;
		internal int serverSentTime;
		internal static readonly byte[] udpHeader0xF3;
		internal static readonly byte[] messageHeader;
		protected bool datagramEncryptedConnection;
		private EnetChannel[] channelArray;
		private Queue<int> commandsToRemove;
	
		// Properties
		internal override int QueuedIncomingCommandsCount { get; }
		internal override int QueuedOutgoingCommandsCount { get; }
		private Encryptor encryptor { get; }
		private Decryptor decryptor { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass51_0
		{
			// Fields
			public byte[] dataCopy;
			public __c__DisplayClass51_1 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass51_0();
	
			// Methods
			internal void _SendToSocket_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass51_1
		{
			// Fields
			public int length;
			public EnetPeer __4__this;
	
			// Constructors
			public __c__DisplayClass51_1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass57_0
		{
			// Fields
			public NCommand readCommand;
			public EnetPeer __4__this;
	
			// Constructors
			public __c__DisplayClass57_0();
	
			// Methods
			internal void _ReceiveIncomingCommands_b__0();
		}
	
		// Constructors
		internal EnetPeer();
		static EnetPeer();
	
		// Methods
		internal override void InitPeerBase();
		internal override bool Connect(string ipport, string appID, object custom = null);
		public override void OnConnect();
		internal override void Disconnect();
		internal override void StopConnection();
		internal override void FetchServerTimestamp();
		internal override bool DispatchIncomingCommands();
		private int GetFragmentLength();
		private int CalculateBufferLen();
		private int CalculateInitialOffset();
		internal override bool SendAcksOnly();
		internal override bool SendOutgoingCommands();
		private bool AreReliableCommandsInTransit();
		internal override bool EnqueueOperation(Dictionary<byte, object> parameters, byte opCode, bool sendReliable, byte channelId, bool encrypt, EgMessageType messageType);
		internal bool CreateAndEnqueueCommand(byte commandType, byte[] payload, byte channelNumber);
		internal override byte[] SerializeOperationToMessage(byte opc, Dictionary<byte, object> parameters, EgMessageType messageType, bool encrypt);
		internal int SerializeToBuffer(Queue<NCommand> commandList);
		internal void SendData(byte[] data, int length);
		private void SendToSocket(byte[] data, int length);
		private void SendDataEncrypted(byte[] data, int length);
		internal void QueueSentCommand(NCommand command);
		internal void QueueOutgoingReliableCommand(NCommand command);
		internal void QueueOutgoingUnreliableCommand(NCommand command);
		internal void QueueOutgoingAcknowledgement(NCommand command);
		internal override void ReceiveIncomingCommands(byte[] inBuff, int dataLength);
		internal bool ExecuteCommand(NCommand command);
		internal bool QueueIncomingCommand(NCommand command);
		internal NCommand RemoveSentReliableCommand(int ackReceivedReliableSequenceNumber, int ackReceivedChannel);
		[CompilerGenerated]
		private void _ExecuteCommand_b__58_0();
	}
}
