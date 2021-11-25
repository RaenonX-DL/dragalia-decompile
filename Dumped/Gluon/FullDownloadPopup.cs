using System.Runtime.CompilerServices;
using Cute.AssetBundle;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class FullDownloadPopup : CommonPopup
	{
		public Text mainText;

		public Text warnText;

		public Text labelText;

		public Text allDataText;

		public Text noVoiceDataText;

		public Text allDataNum;

		public Text voiceDataNum;

		public Text descText;

		public ToggleGroup toggleGroup;

		public bool isPreIn;

		private TitleScene titleScene;

		private DownloadOperation fullDownloadOperation;

		private DownloadOperation noVoiceDownloadOperation;

		private bool exceptVoiceOnFullDownload;

		public static bool isManifestDownloaded
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static FullDownloadPopup CreateFullDownloadPopup(bool isPreIn, TitleScene titleScene)
		{
			return null;
		}

		protected override void Awake()
		{
		}

		private void SetDownloadSize(long fullSize, long noVoiceSize)
		{
		}

		private static void CreateDownloadErrorPopup(DownloadErrorType type, UnityAction onDownloadFailed)
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
