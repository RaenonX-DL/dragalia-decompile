using System;
using System.Collections.Generic;

namespace GooglePlayGames.BasicApi.Nearby
{
	public class DummyNearbyConnectionClient : INearbyConnectionClient
	{
		public int MaxUnreliableMessagePayloadLength()
		{
			return default(int);
		}

		public int MaxReliableMessagePayloadLength()
		{
			return default(int);
		}

		public void SendReliable(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		public void SendUnreliable(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		public void StartAdvertising(string name, List<string> appIdentifiers, TimeSpan? advertisingDuration, Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback)
		{
		}

		public void StopAdvertising()
		{
		}

		public void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<ConnectionResponse> responseCallback, IMessageListener listener)
		{
		}

		public void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, IMessageListener listener)
		{
		}

		public void StartDiscovery(string serviceId, TimeSpan? advertisingTimeout, IDiscoveryListener listener)
		{
		}

		public void StopDiscovery(string serviceId)
		{
		}

		public void RejectConnectionRequest(string requestingEndpointId)
		{
		}

		public void DisconnectFromEndpoint(string remoteEndpointId)
		{
		}

		public void StopAllConnections()
		{
		}

		public string LocalEndpointId()
		{
			return null;
		}

		public string LocalDeviceId()
		{
			return null;
		}

		public string GetAppBundleId()
		{
			return null;
		}

		public string GetServiceId()
		{
			return null;
		}
	}
}
