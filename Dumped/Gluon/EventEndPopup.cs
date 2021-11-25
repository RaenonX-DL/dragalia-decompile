using System;
using System.Collections;
using Gluon.Master;
using UnityEngine.UI;

namespace Gluon
{
	public class EventEndPopup : CommonPopup
	{
		public enum EventPeriod
		{
			NoChecked,
			In,
			Out
		}

		public static string playerPrefsKey;

		public static string playerPrefsKeyForPeriod;

		public Image logoImage;

		[NonSerialized]
		public EventDataElement data;

		private const int useMasterTextEventId = 20802;

		public static IEnumerator CreateIfNeededAsync(Action<bool> onProcessEnd)
		{
			return null;
		}

		private static void CreatePopup(EventDataElement data, Action<bool> onProcessEnd)
		{
		}
	}
}
