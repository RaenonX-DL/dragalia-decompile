using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi.Nearby;
using UnityEngine;

namespace GooglePlayGames.Android
{
	public class AndroidNearbyConnectionClient : INearbyConnectionClient
	{
		private class AdvertisingConnectionLifecycleCallbackProxy : AndroidJavaProxy
		{
			private Action<AdvertisingResult> mResultCallback;

			private Action<ConnectionRequest> mConnectionRequestCallback;

			private AndroidNearbyConnectionClient mClient;

			private string mLocalEndpointName;

			public AdvertisingConnectionLifecycleCallbackProxy(Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback, AndroidNearbyConnectionClient client)
			{
			}

			public void onConnectionInitiated(string endpointId, AndroidJavaObject connectionInfo)
			{
			}

			public void onConnectionResult(string endpointId, AndroidJavaObject connectionResolution)
			{
			}

			public void onDisconnected(string endpointId)
			{
			}
		}

		private class PayloadCallback : AndroidJavaProxy
		{
			private IMessageListener mListener;

			public PayloadCallback(IMessageListener listener)
			{
			}

			public void onPayloadReceived(string endpointId, AndroidJavaObject payload)
			{
			}
		}

		private class DiscoveringConnectionLifecycleCallback : AndroidJavaProxy
		{
			private Action<ConnectionResponse> mResponseCallback;

			private IMessageListener mListener;

			private AndroidJavaObject mClient;

			private string mLocalEndpointName;

			public DiscoveringConnectionLifecycleCallback(Action<ConnectionResponse> responseCallback, IMessageListener listener, AndroidJavaObject client)
			{
			}

			public void onConnectionInitiated(string endpointId, AndroidJavaObject connectionInfo)
			{
			}

			public void onConnectionResult(string endpointId, AndroidJavaObject connectionResolution)
			{
			}

			public void onDisconnected(string endpointId)
			{
			}
		}

		private class EndpointDiscoveryCallback : AndroidJavaProxy
		{
			private IDiscoveryListener mListener;

			public EndpointDiscoveryCallback(IDiscoveryListener listener)
			{
			}

			public void onEndpointFound(string endpointId, AndroidJavaObject endpointInfo)
			{
			}

			public void onEndpointLost(string endpointId)
			{
			}

			private EndpointDetails CreateEndPointDetails(string endpointId, AndroidJavaObject endpointInfo)
			{
				return default(EndpointDetails);
			}
		}

		private class OnGameThreadMessageListener : IMessageListener
		{
			private readonly IMessageListener mListener;

			public OnGameThreadMessageListener(IMessageListener listener)
			{
			}

			public void OnMessageReceived(string remoteEndpointId, byte[] data, bool isReliableMessage)
			{
			}

			public void OnRemoteEndpointDisconnected(string remoteEndpointId)
			{
			}
		}

		private class OnGameThreadDiscoveryListener : IDiscoveryListener
		{
			private readonly IDiscoveryListener mListener;

			public OnGameThreadDiscoveryListener(IDiscoveryListener listener)
			{
			}

			public void OnEndpointFound(EndpointDetails discoveredEndpoint)
			{
			}

			public void OnEndpointLost(string lostEndpointId)
			{
			}
		}

		private AndroidJavaObject mClient;

		private static readonly long NearbyClientId;

		private static readonly int ApplicationInfoFlags;

		private static readonly string ServiceId;

		protected IMessageListener mAdvertisingMessageListener;

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

		private void InternalSend(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		public void StartAdvertising(string name, List<string> appIdentifiers, TimeSpan? advertisingDuration, Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback)
		{
		}

		private AndroidJavaObject CreateAdvertisingOptions()
		{
			return null;
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

		public void StartDiscovery(string serviceId, TimeSpan? advertisingDuration, IDiscoveryListener listener)
		{
		}

		private AndroidJavaObject CreateDiscoveryOptions()
		{
			return null;
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

		public string GetAppBundleId()
		{
			return null;
		}

		public string GetServiceId()
		{
			return null;
		}

		private static string ReadServiceId()
		{
			return null;
		}

		private static Action<T> ToOnGameThread<T>(Action<T> toConvert)
		{
			return null;
		}

		private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert)
		{
			return null;
		}
	}
}
