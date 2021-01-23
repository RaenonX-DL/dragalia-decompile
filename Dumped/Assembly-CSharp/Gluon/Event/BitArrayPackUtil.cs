/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	public static class BitArrayPackUtil
	{
		// Nested types
		public struct Get8Result
		{
			// Fields
			public bool b0;
			public bool b1;
			public bool b2;
			public bool b3;
			public bool b4;
			public bool b5;
			public bool b6;
			public bool b7;
		}
	
		// Methods
		public static byte Pack8(bool b0 = false, bool b1 = false, bool b2 = false, bool b3 = false, bool b4 = false, bool b5 = false, bool b6 = false, bool b7 = false);
		public static byte Pack8(Get8Result param);
		public static Get8Result Unpack8(byte num);
	}
}
