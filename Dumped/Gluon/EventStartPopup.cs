using System;
using System.Collections;
using Gluon.Master;
using UnityEngine.UI;

namespace Gluon
{
	public class EventStartPopup : CommonPopup
	{
		public Image logoImage;

		private EventDataElement data;

		public static string playerPrefsKey;

		public static IEnumerator CreateIfNeededAsync(Action<bool> onProcessEnd)
		{
			return null;
		}

		private static void CreatePopup(EventDataElement data, Action<bool> onProcessEnd)
		{
		}

		public static void GoToEventScene(EventDataElement data)
		{
		}
	}
}
