/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Coneshell
{
	public static class Network
	{
		// Methods
		public static void InitializeContext(byte[] secret, byte[] entropy);
		public static void ResetContext();
		public static byte[] Pack(byte[] plainText);
		public static byte[] Unpack(byte[] packedBytes);
	}
}
