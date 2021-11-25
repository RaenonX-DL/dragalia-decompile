using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class NintendoAccountLinkAskPopup : PopupBase
	{
		private const string prefabPath = "Prefabs/OutGame/TitleMenu/NintendoAccountLinkAskPopupPreIn";

		private const string prefsKeyNotDisplayTodaySettingKey = "NALinkAskNotDisplayTodaySetting";

		[SerializeField]
		private Toggle notDisplayTodayToggle;

		[SerializeField]
		private PointerEventHandler okButtonHandler;

		[SerializeField]
		private PointerEventHandler cancelButtonHandler;

		private Action onNALinkSucceed;

		public static bool IsAsk()
		{
			return default(bool);
		}

		private static int GetCurrentDays()
		{
			return default(int);
		}

		public static NintendoAccountLinkAskPopup Create(Action onNALinkSucceed)
		{
			return null;
		}

		private void Setup(Action onNALinkSucceed)
		{
		}

		public void OnAccountButton()
		{
		}

		public void OnFaqButton()
		{
		}

		private void CreateLinkNintendoAccountSucceedPopup()
		{
		}

		private void OpenLoadingPopup()
		{
		}

		private void CloseLoadingPopup()
		{
		}
	}
}
