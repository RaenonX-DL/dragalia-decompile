/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 44: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.1.2, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon
{
	internal class CmdLogItem
	{
		// Fields
		public int TimeInt;
		public int Channel;
		public int SequenceNumber;
		public int Rtt;
		public int Variance;
	
		// Constructors
		public CmdLogItem();
		public CmdLogItem(NCommand command, int timeInt, int rtt, int variance);
	
		// Methods
		public override string ToString();
	}
}
