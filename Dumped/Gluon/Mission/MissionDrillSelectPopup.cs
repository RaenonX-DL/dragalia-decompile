using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;

namespace Gluon.Mission
{
	public class MissionDrillSelectPopup : MissionSelectPopupBase
	{
		[SerializeField]
		private MissionDrillStepProgressUI stepProgress;

		private int currentMissionDrillGroupId;

		private List<MissionDrillGroupElement> missionDrillGroupList;

		protected override void UpdateBadge()
		{
		}

		public static bool ShouldEnableMissionBadge()
		{
			return default(bool);
		}

		private static MissionDrillSelectPopup CreateSub(Size size = Size.L, BottomButtons bottomButtons = BottomButtons.CancelOk, bool showBlackLayer = true, bool showStartAnimation = true)
		{
			return null;
		}

		public static MissionDrillSelectPopup Create()
		{
			return null;
		}

		protected override void Start()
		{
		}

		protected override TabCategory GetSelectedMissionCategory()
		{
			return default(TabCategory);
		}

		protected override void SetVisibleNoCellEntry(bool isNoEntry)
		{
		}

		public override void InitializeTabButton()
		{
		}

		protected override void InitializeMissionTab()
		{
		}

		private bool IsUnlockedGroup(int tabIndex)
		{
			return default(bool);
		}

		public override void SwitchMissionTab()
		{
		}

		protected override void OpenDetailPopup(int indexInList, int dataIndex)
		{
		}

		private void ScrollToNotClearedMission()
		{
		}

		protected override void SetCellDatas()
		{
		}

		public override void ReloadWithRequestGetList()
		{
		}
	}
}
