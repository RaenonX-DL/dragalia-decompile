/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi.Nearby
{
	public struct ConnectionResponse
	{
		// Fields
		private static readonly byte[] EmptyPayload;
		private readonly long mLocalClientId;
		private readonly string mRemoteEndpointId;
		private readonly Status mResponseStatus;
		private readonly byte[] mPayload;
	
		// Properties
		public long LocalClientId { get; }
		public string RemoteEndpointId { get; }
		public Status ResponseStatus { get; }
		public byte[] Payload { get; }
	
		// Nested types
		public enum Status
		{
			Accepted = 0,
			Rejected = 1,
			ErrorInternal = 2,
			ErrorNetworkNotConnected = 3,
			ErrorEndpointNotConnected = 4,
			ErrorAlreadyConnected = 5
		}
	
		// Constructors
		private ConnectionResponse(long localClientId, string remoteEndpointId, Status code, byte[] payload);
		static ConnectionResponse();
	
		// Methods
		public static ConnectionResponse Rejected(long localClientId, string remoteEndpointId);
		public static ConnectionResponse NetworkNotConnected(long localClientId, string remoteEndpointId);
		public static ConnectionResponse InternalError(long localClientId, string remoteEndpointId);
		public static ConnectionResponse EndpointNotConnected(long localClientId, string remoteEndpointId);
		public static ConnectionResponse Accepted(long localClientId, string remoteEndpointId, byte[] payload);
		public static ConnectionResponse AlreadyConnected(long localClientId, string remoteEndpointId);
	}
}
