/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace CodeStage.AntiCheat.Utils
{
	internal class xxHash
	{
		// Fields
		private const uint PRIME32_1 = 2654435761;
		private const uint PRIME32_2 = 2246822519;
		private const uint PRIME32_3 = 3266489917;
		private const uint PRIME32_4 = 668265263;
		private const uint PRIME32_5 = 374761393;
	
		// Constructors
		public xxHash();
	
		// Methods
		public static uint CalculateHash(byte[] buf, int len, uint seed);
	}
}
