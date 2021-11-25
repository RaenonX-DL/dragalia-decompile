using System;
using Cute.AssetBundle;
using Gluon.Master;
using UnityEngine.UI;

namespace Gluon
{
	public class SelectableCastleStoryDownloadPopup : CommonPopup
	{
		public Text confirmText;

		public Text downloadText;

		public Text wifiText;

		public Text helpText;

		public Text allDataNum;

		public Text voiceDataNum;

		public Text descText;

		public Text shortageText;

		public Text beforeUseNumText;

		public Text afterUseNumText;

		public Text possessionNumText;

		public Text captionUnlockItemText;

		public Image itemIconImage;

		private bool isToQuest;

		private UnitStoryListCellData data;

		private Action onComplete;

		private DownloadOperation downloadOperation;

		private DownloadOperation downloadOperationWithoutVoice;

		private bool exceptVoiceOnFullDownload;

		private const string prefabPath = "Prefabs/OutGame/Fort/UnitStoryList/SelectableCastleStoryDownloadPopup";

		protected override void Awake()
		{
		}

		public static void CreateForQuest(int questId, DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, Action onComplete)
		{
		}

		public static void CreateForCastleStory(UnitStoryListCellData data, DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice)
		{
		}

		public static void CreateForEventStory(EventStoryElement data, DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, Action onComplete)
		{
		}

		private void InitForQuest(int questId, DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, Action onComplete)
		{
		}

		private void InitForCastleStory(UnitStoryListCellData data, DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice)
		{
		}

		private void InitForEventStory(EventStoryElement data, DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, Action onComplete)
		{
		}

		private void SetDownloadSize(long fullSize, long noVoiceSize)
		{
		}

		public void OnDownloadButtonPressed()
		{
		}

		public void OnFullDownloadToggled(bool arg)
		{
		}

		public void OnNoVoiceDownloadToggled(bool arg)
		{
		}
	}
}
