/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 42: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.1.2, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon
{
	public abstract class PhotonPing : IDisposable
	{
		// Fields
		public string DebugString;
		public bool Successful;
		protected internal bool GotResult;
		protected internal int PingLength;
		protected internal byte[] PingBytes;
		protected internal byte PingId;
	
		// Constructors
		protected PhotonPing();
	
		// Methods
		public virtual bool StartPing(string ip);
		public virtual bool Done();
		public virtual void Dispose();
		protected internal void Init();
	}
}
