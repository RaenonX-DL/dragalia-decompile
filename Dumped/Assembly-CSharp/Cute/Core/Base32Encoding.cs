/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Core
{
	public static class Base32Encoding
	{
		// Fields
		private const char Padding = '=';
	
		// Methods
		public static string ToString(byte[] input, bool padding = true);
		public static byte[] ToBytes(string input);
		private static char ByteToChar(byte b);
		private static int CharToByte(char c);
	}
}
