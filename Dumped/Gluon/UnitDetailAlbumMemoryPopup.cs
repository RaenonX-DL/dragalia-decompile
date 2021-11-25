using System.Collections.Generic;
using Cute.Cri;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class UnitDetailAlbumMemoryPopup : PopupBase
	{
		public enum MemoryType
		{
			summon,
			awaking,
			awakingSecond,
			win,
			questFailed,
			dead
		}

		public Dictionary<MemoryType, string> memoryData;

		[SerializeField]
		private GameObject memoryButtonPrefab;

		[SerializeField]
		private Transform scrollViewContent;

		private CharaDataElement masterCharaData;

		private string[] voiceGroupName;

		private AudioPlayback soundPlayBack;

		private Camera flashCamera;

		public UnitDetailScene scene;

		public static UnitDetailAlbumMemoryPopup Create(UnitDetailModel.CharaDetailData data, Camera flashCamera, bool showBlackLayer = true)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void InitContents(UnitDetailModel.CharaDetailData data, Camera camera)
		{
		}

		protected override void OnDestroy()
		{
		}

		public void OnMemoryButtonPressed(MemoryType type)
		{
		}

		private void OnSummonButtonpressed()
		{
		}

		private void OnAwakingButtonPressed()
		{
		}

		private void OnAwakingButtonSecondPressed()
		{
		}

		private void OnWinButtonpressed()
		{
		}

		private void OnQuestFailedButtonpressed()
		{
		}

		private void OnDeadButtonpressed()
		{
		}

		private void StopVoice()
		{
		}
	}
}
