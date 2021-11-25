using System.Runtime.InteropServices;

namespace GooglePlayGames.BasicApi.Nearby
{
	[StructLayout(0, Size = 24)]
	public struct EndpointDetails
	{
		private readonly string mEndpointId;

		private readonly string mName;

		private readonly string mServiceId;

		public string EndpointId => null;

		public string Name => null;

		public string ServiceId => null;

		public EndpointDetails(string endpointId, string name, string serviceId)
		{
		}
	}
}
