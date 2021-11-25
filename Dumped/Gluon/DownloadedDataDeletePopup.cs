using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DownloadedDataDeletePopup : CommonPopup
	{
		private enum DeleteType
		{
			AllQuest,
			Voice,
			MyPage3d
		}

		public Text allQuestSizeNum;

		public Text voiceSizeNum;

		public Text myPage3dSizeNum;

		public Text totalSizeNum;

		public Text overlappingSizeNum;

		public GameObject overlappingTextRoot;

		private HashSet<string> allQuestDeleteAssets;

		private HashSet<string> voiceDeleteAssets;

		private HashSet<string> myPage3dDeleteAssets;

		private HashSet<string> myPage3dVoiceDeleteAssets;

		private HashSet<string> totalDeleteAssets;

		public Toggle[] toggleList;

		private long allQuestDeleteSize;

		private long voiceDeleteSize;

		private long myPage3dDeleteSize;

		private long myPage3dVoiceDeleteSize;

		private long totalDeleteSize;

		private long overlappingDeleteSize;

		public static DownloadedDataDeletePopup CreateDownloadedDataDeletePopup()
		{
			return null;
		}

		public IEnumerator CheckManifestAndCollectDeleteAssets(PopupBase activePopup)
		{
			return null;
		}

		private void UpdateDeleteSize()
		{
		}

		private void ToggleCheckBox(DeleteType type, bool value)
		{
		}

		private bool IsCheckBoxToggled(DeleteType type)
		{
			return default(bool);
		}

		public void OnAllQuestToggled(bool arg)
		{
		}

		public void OnVoiceToggled(bool arg)
		{
		}

		public void OnMyPage3dToggled(bool arg)
		{
		}

		public void OnDeleteButtonPressed()
		{
		}

		private static IEnumerator CollectDeleteAsset(HashSet<string> targetQuestAssets, HashSet<string> reservedQuestAssets)
		{
			return null;
		}

		private IEnumerator DeleteDownloadedData()
		{
			return null;
		}
	}
}
