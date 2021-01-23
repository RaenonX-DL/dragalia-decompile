/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Core
{
	public class Cryptographer
	{
		// Constructors
		public Cryptographer();
	
		// Methods
		public static byte[] EncryptRJ256(byte[] src, string key, string iv);
		public static byte[] EncryptRJ256(byte[] src, byte[] key, byte[] iv);
		public static byte[] DecryptRJ256(byte[] src, string key, string iv);
		public static byte[] DecryptRJ256(byte[] src, byte[] key, byte[] iv);
		public static string CreateKey();
		public static string CreateIV();
	}
}
