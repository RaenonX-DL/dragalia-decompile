/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class VoiceOutPutAnalyzer
	{
		// Fields
		private const int ChannelL = 0;
		private const int ChannelR = 1;
		private const int VoiceDspBusId = 1;
		private static BusAnalyzer busAnalyzer;
	
		// Constructors
		static VoiceOutPutAnalyzer();
	
		// Methods
		public static void Enable();
		public static void Disable();
		public static float GetVolumeRaito();
	}
}
