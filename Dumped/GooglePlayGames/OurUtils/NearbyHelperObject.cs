using System;
using GooglePlayGames.BasicApi.Nearby;
using UnityEngine;

namespace GooglePlayGames.OurUtils
{
	public class NearbyHelperObject : MonoBehaviour
	{
		private static NearbyHelperObject instance;

		private static double mAdvertisingRemaining;

		private static double mDiscoveryRemaining;

		private static INearbyConnectionClient mClient;

		public static void CreateObject(INearbyConnectionClient client)
		{
		}

		private static double ToSeconds(TimeSpan? span)
		{
			return default(double);
		}

		public static void StartAdvertisingTimer(TimeSpan? span)
		{
		}

		public static void StartDiscoveryTimer(TimeSpan? span)
		{
		}

		public void Awake()
		{
		}

		public void OnDisable()
		{
		}

		public void Update()
		{
		}
	}
}
