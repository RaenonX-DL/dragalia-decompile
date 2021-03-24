/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 44: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.1.2, Culture=neutral, PublicKeyToken=null

namespace Photon.SocketServer.Security
{
	internal interface ICryptoProvider : IDisposable
	{
		// Properties
		byte[] PublicKey { get; }
	
		// Methods
		void DeriveSharedKey(byte[] otherPartyPublicKey);
		byte[] Encrypt(byte[] data);
		byte[] Decrypt(byte[] data, int offset, int count);
	}
}
