using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class TotalDamageEventNotifiyReceivableRewardPopup : PopupBase
	{
		[SerializeField]
		private Text descriptionText;

		[SerializeField]
		private Image eventLogoImage;

		private EventDataElement receivableRewardEventData;

		private UnityEvent okButtonPressed;

		private static bool isFinishedShowingPopup;

		private static readonly string notifiyReceivableRewardPopupPath;

		private static readonly string eventLogoPath;

		private static readonly Vector2 eventLogoSize;

		public static TotalDamageEventNotifiyReceivableRewardPopup Create(EventDataElement eventData)
		{
			return null;
		}

		private void Initialize()
		{
		}

		public static List<EventDataElement> CreateNeedShowPopupEventList()
		{
			return null;
		}

		public void OkButtonPressed()
		{
		}

		public void AddOkButtonPressedCallback(UnityAction callback)
		{
		}
	}
}
