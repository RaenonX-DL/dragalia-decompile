/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 44: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.1.2, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon
{
	internal class SocketTcp : IPhotonSocket, IDisposable
	{
		// Fields
		private Socket sock;
		private readonly object syncer;
	
		// Constructors
		public SocketTcp(PeerBase npeer);
	
		// Methods
		public void Dispose();
		public override bool Connect();
		public override bool Disconnect();
		public override PhotonSocketError Send(byte[] data, int length);
		public void DnsAndConnect();
		public void ReceiveLoop();
	}
}
