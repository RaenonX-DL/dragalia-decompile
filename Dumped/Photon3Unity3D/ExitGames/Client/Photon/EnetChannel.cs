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
	internal class EnetChannel
	{
		// Fields
		internal byte ChannelNumber;
		internal Dictionary<int, NCommand> incomingReliableCommandsList;
		internal Dictionary<int, NCommand> incomingUnreliableCommandsList;
		internal Queue<NCommand> outgoingReliableCommandsList;
		internal Queue<NCommand> outgoingUnreliableCommandsList;
		internal int incomingReliableSequenceNumber;
		internal int incomingUnreliableSequenceNumber;
		internal int outgoingReliableSequenceNumber;
		internal int outgoingUnreliableSequenceNumber;
	
		// Constructors
		public EnetChannel(byte channelNumber, int commandBufferSize);
	
		// Methods
		public bool ContainsUnreliableSequenceNumber(int unreliableSequenceNumber);
		public bool ContainsReliableSequenceNumber(int reliableSequenceNumber);
		public NCommand FetchReliableSequenceNumber(int reliableSequenceNumber);
		public void clearAll();
	}
}
