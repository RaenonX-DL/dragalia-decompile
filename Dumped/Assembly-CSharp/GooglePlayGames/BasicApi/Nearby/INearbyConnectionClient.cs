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
	public interface INearbyConnectionClient
	{
		// Methods
		int MaxUnreliableMessagePayloadLength();
		int MaxReliableMessagePayloadLength();
		void SendReliable(List<string> recipientEndpointIds, byte[] payload);
		void SendUnreliable(List<string> recipientEndpointIds, byte[] payload);
		void StartAdvertising(string name, List<string> appIdentifiers, TimeSpan? advertisingDuration, Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback);
		void StopAdvertising();
		void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<ConnectionResponse> responseCallback, IMessageListener listener);
		void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, IMessageListener listener);
		void StartDiscovery(string serviceId, TimeSpan? advertisingTimeout, IDiscoveryListener listener);
		void StopDiscovery(string serviceId);
		void RejectConnectionRequest(string requestingEndpointId);
		void DisconnectFromEndpoint(string remoteEndpointId);
		void StopAllConnections();
		string GetAppBundleId();
		string GetServiceId();
	}
}
