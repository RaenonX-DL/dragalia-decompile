/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi.Nearby
{
	public struct ConnectionRequest
	{
		// Fields
		private readonly EndpointDetails mRemoteEndpoint;
		private readonly byte[] mPayload;
	
		// Properties
		public EndpointDetails RemoteEndpoint { get; }
		public byte[] Payload { get; }
	
		// Constructors
		public ConnectionRequest(string remoteEndpointId, string remoteEndpointName, string serviceId, byte[] payload);
	}
}
