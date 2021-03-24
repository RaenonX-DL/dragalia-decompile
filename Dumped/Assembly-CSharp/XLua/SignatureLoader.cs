/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace XLua
{
	public class SignatureLoader
	{
		// Fields
		private LuaEnv.CustomLoader userLoader;
		private RSACryptoServiceProvider rsa;
		private SHA1 sha;
	
		// Constructors
		public SignatureLoader(string publicKey, LuaEnv.CustomLoader loader);
	
		// Methods
		private byte[] load_and_verify(ref string filepath);
		public static implicit operator LuaEnv.CustomLoader(SignatureLoader signatureLoader);
	}
}
