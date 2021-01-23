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
	internal class CmdLogSentReliable : CmdLogItem
	{
		// Fields
		public int Resend;
		public int RoundtripTimeout;
		public int Timeout;
		public bool TriggeredTimeout;
	
		// Constructors
		public CmdLogSentReliable(NCommand command, int timeInt, int rtt, int variance, bool triggeredTimeout = false);
	
		// Methods
		public override string ToString();
	}
}
