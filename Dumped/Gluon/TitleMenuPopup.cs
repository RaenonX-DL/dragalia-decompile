using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class TitleMenuPopup : PopupBase, ICustomMessage
	{
		private const string prefabPathForTitle = "Prefabs/OutGame/TitleMenu/TitleMenuPopup";

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Button cacheClearButton;

		[SerializeField]
		private Button downloaedDataDeleteButton;

		[SerializeField]
		private Badge inquiryBadge;

		[NonSerialized]
		public TitleScene titleScene;

		public static bool isCacheFilesExist;

		private bool isHavingUnreadComments;

		public static TitleMenuPopup Create(bool isHavingUnreadComments)
		{
			return null;
		}

		protected override void Start()
		{
		}

		private void SetButtonEnable(Button target, bool value)
		{
		}

		private void OnDisable()
		{
		}

		public void InitSetting(TitleScene titleScene)
		{
		}

		public void OnInformationButtonPressed()
		{
		}

		public static IEnumerator CheckCacheFilesExist()
		{
			return null;
		}

		public void OnCacheClearButtonPressed()
		{
		}

		public void OnFaqButtonPressed()
		{
		}

		public void OnInquiryButtonPressed()
		{
		}

		private void UpdateResourceVersion(Action next)
		{
		}

		private void UpdateUserData(Action next)
		{
		}

		public void OnCloseButtonPressed()
		{
		}

		public void OnLanguageSettingButtonPressed()
		{
		}

		public void OnFullDownloadButtonPressed()
		{
		}

		private IEnumerator OnFullDownloadButtonPressedCoroutine()
		{
			return null;
		}

		public void OnDownloaedDataDeleteButtonPressed()
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}
	}
}
