using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon.Mission
{
	public class MissionSelectPopup : MissionSelectPopupBase
	{
		private static readonly List<TabCategory> enableTabCategories;

		private static TabCategory _selectMissionCategory;

		[SerializeField]
		private Image pickupBadge;

		public Button toShopButton;

		public Text toShopButtonText;

		[SerializeField]
		protected Text switchHistoryText;

		protected bool isShowHistory;

		public static TabCategory selectMissionCategory
		{
			get
			{
				return default(TabCategory);
			}
			set
			{
			}
		}

		private static int ConvertCategoryToIndex(TabCategory category)
		{
			return default(int);
		}

		private static TabCategory ConvertIndexToCategory(int index)
		{
			return default(TabCategory);
		}

		protected override void UpdateBadge()
		{
		}

		public static bool ShouldEnableMissionBadge()
		{
			return default(bool);
		}

		private static MissionSelectPopup CreateSub(Size size = Size.L, BottomButtons bottomButtons = BottomButtons.CancelOk, bool showBlackLayer = true, bool showStartAnimation = true)
		{
			return null;
		}

		public static void Create([Optional] Action<MissionSelectPopup> onComplete)
		{
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

		public override void ReloadData()
		{
		}

		public void OnSwitchHistoryButtonPressed()
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
