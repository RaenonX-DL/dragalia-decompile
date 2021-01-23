/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi.Nearby
{
	public class DummyNearbyConnectionClient : INearbyConnectionClient
	{
		// Constructors
		public DummyNearbyConnectionClient();
	
		// Methods
		public int MaxUnreliableMessagePayloadLength();
		public int MaxReliableMessagePayloadLength();
		public void SendReliable(List<string> recipientEndpointIds, byte[] payload);
		public void SendUnreliable(List<string> recipientEndpointIds, byte[] payload);
		public void StartAdvertising(string name, List<string> appIdentifiers, TimeSpan? advertisingDuration, Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback);
		public void StopAdvertising();
		public void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<ConnectionResponse> responseCallback, IMessageListener listener);
		public void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, IMessageListener listener);
		public void StartDiscovery(string serviceId, TimeSpan? advertisingTimeout, IDiscoveryListener listener);
		public void StopDiscovery(string serviceId);
		public void RejectConnectionRequest(string requestingEndpointId);
		public void DisconnectFromEndpoint(string remoteEndpointId);
		public void StopAllConnections();
		public string LocalEndpointId();
		public string LocalDeviceId();
		public string GetAppBundleId();
		public string GetServiceId();
	}
}
