using System;
using Cute.AssetBundle;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MemoryEventDownloadPopup : PopupBase
	{
		[SerializeField]
		public Image logo;

		public Toggle voiceOnToggle;

		public Toggle voiceOffToggle;

		public Text donwloadSizeText;

		public Text withoutVoiceDownloadSizeText;

		private Action onDone;

		private Action onCancel;

		private DownloadOperation operation;

		private DownloadOperation withoutVoiceOperation;

		private int eventId;

		private const string prefabPath = "Prefabs/OutGame/QuestSelect/Popup/MemoryEventDownloadPopup";

		public static MemoryEventDownloadPopup Create(int eventId, DownloadOperation operation, DownloadOperation withoutVoiceOperation, Action onDone, Action onCancel)
		{
			return null;
		}

		protected override void Start()
		{
		}

		private void SetDownloadSize()
		{
		}

		public void OnOKButtonPressed()
		{
		}

		public void OnCancelButtonPressed()
		{
		}
	}
}
