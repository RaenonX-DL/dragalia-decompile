/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Core
{
	public static class Hash
	{
		// Nested types
		public enum EncodeType
		{
			Base32 = 0,
			Base64 = 1,
			Hex = 2,
			Base32NoPadding = 3
		}
	
		// Methods
		public static string ComputeSha1Hash(string input, EncodeType encoding = EncodeType.Base32);
		public static string ComputeMd5Hash(string input, EncodeType encoding = EncodeType.Base32);
		public static string ComputeSha256Hash(string input, EncodeType encoding = EncodeType.Base32);
		public static string ComputeSha256Hash(byte[] input, EncodeType encoding = EncodeType.Base32);
		public static string ComputeMd5HashOfFile(string path, EncodeType encoding = EncodeType.Base32);
		public static string ComputeSha256HashOfFile(string path, EncodeType encoding = EncodeType.Base32);
		public static string ToHexString(byte[] src);
		private static string Encode(byte[] src, EncodeType encoding);
	}
}
