namespace GooglePlayGames.BasicApi.Nearby
{
	public struct ConnectionResponse
	{
		public enum Status
		{
			Accepted,
			Rejected,
			ErrorInternal,
			ErrorNetworkNotConnected,
			ErrorEndpointNotConnected,
			ErrorAlreadyConnected
		}

		private static readonly byte[] EmptyPayload;

		private readonly long mLocalClientId;

		private readonly string mRemoteEndpointId;

		private readonly Status mResponseStatus;

		private readonly byte[] mPayload;

		public long LocalClientId => default(long);

		public string RemoteEndpointId => null;

		public Status ResponseStatus => default(Status);

		public byte[] Payload => null;

		private ConnectionResponse(long localClientId, string remoteEndpointId, Status code, byte[] payload)
		{
		}

		public static ConnectionResponse Rejected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		public static ConnectionResponse NetworkNotConnected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		public static ConnectionResponse InternalError(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		public static ConnectionResponse EndpointNotConnected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		public static ConnectionResponse Accepted(long localClientId, string remoteEndpointId, byte[] payload)
		{
			return default(ConnectionResponse);
		}

		public static ConnectionResponse AlreadyConnected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}
	}
}
