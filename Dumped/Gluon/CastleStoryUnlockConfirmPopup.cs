using System;
using Cute.AssetBundle;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CastleStoryUnlockConfirmPopup : PopupBase
	{
		private const string prefabPath = "Prefabs/OutGame/Fort/UnitStoryList/CastleStoryUnlockConfirmPopup";

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Button okButton;

		[SerializeField]
		private Text okText;

		[SerializeField]
		private Button cancelButton;

		[SerializeField]
		private Text cancelText;

		[SerializeField]
		private Text confirmText;

		[SerializeField]
		private Text downloadText;

		[SerializeField]
		private Text wifiText;

		[SerializeField]
		private Text helpText;

		[SerializeField]
		private Text shortageText;

		[SerializeField]
		private Text beforeUseNumText;

		[SerializeField]
		private Text afterUseNumText;

		[SerializeField]
		private Text possessionNumText;

		[SerializeField]
		private Text captionUnlockItemText;

		[SerializeField]
		private Image itemIconImage;

		private bool isToQuest;

		private UnitStoryListCellData data;

		private Action onComplete;

		public static void CreateForStoryQuest(int questId, DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, Action onComplete)
		{
		}

		public static void CreateForCastleStory(UnitStoryListCellData data, DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice)
		{
		}

		public static void CreateForEventStory(EventStoryElement data, DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, Action onComplete)
		{
		}

		private void InitForQuest(int questId, Action onComplete)
		{
		}

		private void InitForCastleStory(UnitStoryListCellData data)
		{
		}

		private void InitForEventStory(EventStoryElement data, Action onComplete)
		{
		}

		public void OnCancelButtonPressed()
		{
		}

		public void OnOkButtonPressed()
		{
		}
	}
}
