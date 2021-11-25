using System.Runtime.CompilerServices;
using Cute.AssetBundle;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SelectableDownloadPopup : CommonPopup
	{
		public enum DownloadMode
		{
			Full,
			WithoutVoice,
			Minimum
		}

		public Text mainText;

		public Text warnText;

		public Text labelText;

		public Text allDataText;

		public Text noVoiceDataText;

		public Text allDataNum;

		public Text voiceDataNum;

		public Text minimumDataNum;

		public Text descText;

		public ToggleGroup toggleGroup;

		public Toggle voiceOnToggle;

		public Toggle voiceOffToggle;

		public Toggle minimumToggle;

		public GameObject deleteSizeRoot;

		public Text deleteDataNum;

		private bool isPreIn;

		private DownloadOperation downloadOperation;

		private DownloadOperation downloadOperationWithoutVoice;

		private DownloadOperation downloadOperationMinimum;

		private bool updateSaveVoiceAsset;

		private bool changeOptionSetting;

		private const string prefsKeyToggleSelect = "SelectableDownloadPopup/ToggleSelect";

		public bool isWithoutVoice => default(bool);

		private DownloadMode downloadMode
		{
			[CompilerGenerated]
			get
			{
				return default(DownloadMode);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static SelectableDownloadPopup CreateSelectableDownloadPopup(bool isPreIn, DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, DownloadOperation downloadOperationMinimum, bool updateSaveVoiceAsset, bool changeOptionSetting, long deletedSize = 0L)
		{
			return null;
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void SetDownloadSize()
		{
		}

		public void ChangeMainTextForVoiceDownload()
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

		public void OnMinimunDownloadToggled(bool arg)
		{
		}

		public static DownloadMode GetDefaultSelectedMode(bool isMinimunEnable)
		{
			return default(DownloadMode);
		}
	}
}
