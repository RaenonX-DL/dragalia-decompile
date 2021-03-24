/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GooglePlayGames.BasicApi.Nearby;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.Android
{
	public class AndroidNearbyConnectionClient : INearbyConnectionClient
	{
		// Fields
		private AndroidJavaObject mClient;
		private static readonly long NearbyClientId;
		private static readonly int ApplicationInfoFlags;
		private static readonly string ServiceId;
		protected IMessageListener mAdvertisingMessageListener;
	
		// Nested types
		private class AdvertisingConnectionLifecycleCallbackProxy : AndroidJavaProxy
		{
			// Fields
			private Action<AdvertisingResult> mResultCallback;
			private Action<ConnectionRequest> mConnectionRequestCallback;
			private AndroidNearbyConnectionClient mClient;
			private string mLocalEndpointName;
	
			// Constructors
			public AdvertisingConnectionLifecycleCallbackProxy(Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback, AndroidNearbyConnectionClient client);
	
			// Methods
			public void onConnectionInitiated(string endpointId, AndroidJavaObject connectionInfo);
			public void onConnectionResult(string endpointId, AndroidJavaObject connectionResolution);
			public void onDisconnected(string endpointId);
		}
	
		private class PayloadCallback : AndroidJavaProxy
		{
			// Fields
			private IMessageListener mListener;
	
			// Constructors
			public PayloadCallback(IMessageListener listener);
	
			// Methods
			public void onPayloadReceived(string endpointId, AndroidJavaObject payload);
		}
	
		private class DiscoveringConnectionLifecycleCallback : AndroidJavaProxy
		{
			// Fields
			private Action<ConnectionResponse> mResponseCallback;
			private IMessageListener mListener;
			private AndroidJavaObject mClient;
			private string mLocalEndpointName;
	
			// Constructors
			public DiscoveringConnectionLifecycleCallback(Action<ConnectionResponse> responseCallback, IMessageListener listener, AndroidJavaObject client);
	
			// Methods
			public void onConnectionInitiated(string endpointId, AndroidJavaObject connectionInfo);
			public void onConnectionResult(string endpointId, AndroidJavaObject connectionResolution);
			public void onDisconnected(string endpointId);
		}
	
		private class EndpointDiscoveryCallback : AndroidJavaProxy
		{
			// Fields
			private IDiscoveryListener mListener;
	
			// Constructors
			public EndpointDiscoveryCallback(IDiscoveryListener listener);
	
			// Methods
			public void onEndpointFound(string endpointId, AndroidJavaObject endpointInfo);
			public void onEndpointLost(string endpointId);
			private EndpointDetails CreateEndPointDetails(string endpointId, AndroidJavaObject endpointInfo);
		}
	
		private class OnGameThreadMessageListener : IMessageListener
		{
			// Fields
			private readonly IMessageListener mListener;
	
			// Nested types
			[CompilerGenerated]
			private sealed class __c__DisplayClass2_0
			{
				// Fields
				public OnGameThreadMessageListener __4__this;
				public string remoteEndpointId;
				public byte[] data;
				public bool isReliableMessage;
	
				// Constructors
				public __c__DisplayClass2_0();
	
				// Methods
				internal void _OnMessageReceived_b__0();
			}
	
			[CompilerGenerated]
			private sealed class __c__DisplayClass3_0
			{
				// Fields
				public OnGameThreadMessageListener __4__this;
				public string remoteEndpointId;
	
				// Constructors
				public __c__DisplayClass3_0();
	
				// Methods
				internal void _OnRemoteEndpointDisconnected_b__0();
			}
	
			// Constructors
			public OnGameThreadMessageListener(IMessageListener listener);
	
			// Methods
			public void OnMessageReceived(string remoteEndpointId, byte[] data, bool isReliableMessage);
			public void OnRemoteEndpointDisconnected(string remoteEndpointId);
		}
	
		private class OnGameThreadDiscoveryListener : IDiscoveryListener
		{
			// Fields
			private readonly IDiscoveryListener mListener;
	
			// Nested types
			[CompilerGenerated]
			private sealed class __c__DisplayClass2_0
			{
				// Fields
				public OnGameThreadDiscoveryListener __4__this;
				public EndpointDetails discoveredEndpoint;
	
				// Constructors
				public __c__DisplayClass2_0();
	
				// Methods
				internal void _OnEndpointFound_b__0();
			}
	
			[CompilerGenerated]
			private sealed class __c__DisplayClass3_0
			{
				// Fields
				public OnGameThreadDiscoveryListener __4__this;
				public string lostEndpointId;
	
				// Constructors
				public __c__DisplayClass3_0();
	
				// Methods
				internal void _OnEndpointLost_b__0();
			}
	
			// Constructors
			public OnGameThreadDiscoveryListener(IDiscoveryListener listener);
	
			// Methods
			public void OnEndpointFound(EndpointDetails discoveredEndpoint);
			public void OnEndpointLost(string lostEndpointId);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public TimeSpan? advertisingDuration;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _StartAdvertising_b__0(AndroidJavaObject v);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public TimeSpan? advertisingDuration;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _StartDiscovery_b__0(AndroidJavaObject v);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0<T>
		{
			// Fields
			public Action<T> toConvert;
	
			// Constructors
			public __c__DisplayClass31_0();
	
			// Methods
			internal void _ToOnGameThread_b__0(T val);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_1<T>
		{
			// Fields
			public T val;
			public __c__DisplayClass31_0<T> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass31_1();
	
			// Methods
			internal void _ToOnGameThread_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0<T1, T2>
		{
			// Fields
			public Action<T1, T2> toConvert;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal void _ToOnGameThread_b__0(T1 val1, T2 val2);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_1<T1, T2>
		{
			// Fields
			public T1 val1;
			public T2 val2;
			public __c__DisplayClass32_0<T1, T2> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass32_1();
	
			// Methods
			internal void _ToOnGameThread_b__1();
		}
	
		// Constructors
		public AndroidNearbyConnectionClient();
		static AndroidNearbyConnectionClient();
	
		// Methods
		public int MaxUnreliableMessagePayloadLength();
		public int MaxReliableMessagePayloadLength();
		public void SendReliable(List<string> recipientEndpointIds, byte[] payload);
		public void SendUnreliable(List<string> recipientEndpointIds, byte[] payload);
		private void InternalSend(List<string> recipientEndpointIds, byte[] payload);
		public void StartAdvertising(string name, List<string> appIdentifiers, TimeSpan? advertisingDuration, Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback);
		private AndroidJavaObject CreateAdvertisingOptions();
		public void StopAdvertising();
		public void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<ConnectionResponse> responseCallback, IMessageListener listener);
		public void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, IMessageListener listener);
		public void StartDiscovery(string serviceId, TimeSpan? advertisingDuration, IDiscoveryListener listener);
		private AndroidJavaObject CreateDiscoveryOptions();
		public void StopDiscovery(string serviceId);
		public void RejectConnectionRequest(string requestingEndpointId);
		public void DisconnectFromEndpoint(string remoteEndpointId);
		public void StopAllConnections();
		public string GetAppBundleId();
		public string GetServiceId();
		private static string ReadServiceId();
		private static Action<T> ToOnGameThread<T>(Action<T> toConvert);
		private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert);
	}
}
