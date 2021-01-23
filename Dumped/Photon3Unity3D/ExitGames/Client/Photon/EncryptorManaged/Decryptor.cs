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
	public class Decryptor : CryptoBase
	{
		// Fields
		private readonly byte[] IV;
		private readonly byte[] readBuffer;
	
		// Constructors
		public Decryptor();
	
		// Methods
		public byte[] DecryptBufferWithIV(byte[] data, int offset, int len, out int outLen);
		public bool CheckHMAC(byte[] data, int len);
	}
}
