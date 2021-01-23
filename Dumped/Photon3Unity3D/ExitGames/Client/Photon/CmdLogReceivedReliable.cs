/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 42: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.1.2, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon
{
	internal class CmdLogReceivedReliable : CmdLogItem
	{
		// Fields
		public int TimeSinceLastSend;
		public int TimeSinceLastSendAck;
	
		// Constructors
		public CmdLogReceivedReliable(NCommand command, int timeInt, int rtt, int variance, int timeSinceLastSend, int timeSinceLastSendAck);
	
		// Methods
		public override string ToString();
	}
}
