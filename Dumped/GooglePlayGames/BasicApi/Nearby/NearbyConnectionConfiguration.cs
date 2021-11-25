using System;

namespace GooglePlayGames.BasicApi.Nearby
{
	public struct NearbyConnectionConfiguration
	{
		public const int MaxUnreliableMessagePayloadLength = 1168;

		public const int MaxReliableMessagePayloadLength = 4096;

		private readonly Action<InitializationStatus> mInitializationCallback;

		private readonly long mLocalClientId;

		public long LocalClientId => default(long);

		public Action<InitializationStatus> InitializationCallback => null;

		public NearbyConnectionConfiguration(Action<InitializationStatus> callback, long localClientId)
		{
		}
	}
}
