/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class Crc32
	{
		// Fields
		private static readonly uint[] crcTable;
	
		// Constructors
		static Crc32();
	
		// Methods
		public static void MakeCrcTable();
		public static uint Get(byte[] buf);
		public static uint Get(string str);
	}
}
