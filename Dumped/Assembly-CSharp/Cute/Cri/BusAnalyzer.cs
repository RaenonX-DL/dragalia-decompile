/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Cri
{
	public class BusAnalyzer : IDisposable
	{
		// Fields
		private GCHandle gch;
		private byte[] bytes;
	
		// Properties
		private IntPtr Ptr { get; }
	
		// Constructors
		public BusAnalyzer();
	
		// Methods
		private static extern void criAtomExAsr_GetBusAnalyzerInfo(int bus_no, IntPtr info);
		public void Dispose();
		public float GetPeakLevel(int bus, int channel);
	}
}
