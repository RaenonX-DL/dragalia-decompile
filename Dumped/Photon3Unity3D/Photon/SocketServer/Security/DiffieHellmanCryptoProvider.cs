/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Photon.SocketServer.Numeric;

// Image 42: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.1.2, Culture=neutral, PublicKeyToken=null

namespace Photon.SocketServer.Security
{
	internal class DiffieHellmanCryptoProvider : ICryptoProvider
	{
		// Fields
		private static readonly BigInteger primeRoot;
		private readonly BigInteger prime;
		private readonly BigInteger secret;
		private readonly BigInteger publicKey;
		private Rijndael crypto;
		private byte[] sharedKey;
	
		// Properties
		public byte[] PublicKey { get; }
	
		// Constructors
		public DiffieHellmanCryptoProvider();
		public DiffieHellmanCryptoProvider(byte[] sharedSecretHash);
		static DiffieHellmanCryptoProvider();
	
		// Methods
		public void DeriveSharedKey(byte[] otherPartyPublicKey);
		public byte[] Encrypt(byte[] data);
		public byte[] Encrypt(byte[] data, int offset, int count);
		public byte[] Decrypt(byte[] data, int offset, int count);
		public void Dispose();
		protected void Dispose(bool disposing);
		private BigInteger CalculatePublicKey();
		private BigInteger CalculateSharedKey(BigInteger otherPartyPublicKey);
		private BigInteger GenerateRandomSecret(int secretLength);
	}
}
