using System;
using System.Collections.Generic;
using UnityEngine;
using com.adjust.sdk;

namespace Gluon
{
	public class AdjustConf : ScriptableObject
	{
		[Serializable]
		private class EventItem
		{
			public string key;

			public string token;
		}

		[SerializeField]
		public string appToken;

		[SerializeField]
		public List<long> signature;

		[SerializeField]
		public AdjustLogLevel logLevel;

		[SerializeField]
		private List<EventItem> events;

		public const AdjustEnvironment environment = AdjustEnvironment.Production;

		private static string region;

		private static AdjustConf _instance;

		public static AdjustConf instance => null;

		public static void SetRegion(string location)
		{
		}

		public string GetAppToken()
		{
			return null;
		}

		public AdjustLogLevel GetLogLevel()
		{
			return default(AdjustLogLevel);
		}

		public string GetEventToken(string eventName)
		{
			return null;
		}

		private EventItem GetEventItem(string name)
		{
			return null;
		}
	}
}
