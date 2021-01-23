/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 42: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.1.2, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon.EncryptorManaged
{
	public class Encryptor : CryptoBase
	{
		// Fields
		private static readonly byte[] zeroBytes;
	
		// Constructors
		public Encryptor();
		static Encryptor();
	
		// Methods
		public void Encrypt(byte[] data, int len, byte[] output, ref int offset);
		public byte[] FinishHMAC(byte[] data, int offset, int count);
	}
}
