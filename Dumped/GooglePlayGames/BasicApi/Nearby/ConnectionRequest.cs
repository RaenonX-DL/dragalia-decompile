using System.Runtime.InteropServices;

namespace GooglePlayGames.BasicApi.Nearby
{
	[StructLayout(0, Size = 32)]
	public struct ConnectionRequest
	{
		private readonly EndpointDetails mRemoteEndpoint;

		private readonly byte[] mPayload;

		public EndpointDetails RemoteEndpoint => default(EndpointDetails);

		public byte[] Payload => null;

		public ConnectionRequest(string remoteEndpointId, string remoteEndpointName, string serviceId, byte[] payload)
		{
		}
	}
}
