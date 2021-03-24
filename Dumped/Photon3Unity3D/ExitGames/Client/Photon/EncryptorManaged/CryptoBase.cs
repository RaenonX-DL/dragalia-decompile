/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Image 44: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.1.2, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon.EncryptorManaged
{
	public class CryptoBase : IDisposable
	{
		// Fields
		public const int BLOCK_SIZE = 16;
		public const int IV_SIZE = 16;
		public const int HMAC_SIZE = 32;
		protected Aes encryptor;
		protected HMACSHA256 hmacsha256;
	
		// Constructors
		public CryptoBase();
	
		// Methods
		~CryptoBase();
		public void Init(byte[] encryptionSecret, byte[] hmacSecret);
		public void Dispose();
		private void Dispose(bool dispose);
	}
}
