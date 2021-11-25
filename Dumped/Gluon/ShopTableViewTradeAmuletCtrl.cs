using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class ShopTableViewTradeAmuletCtrl : TableViewController<ShopTableViewTradeAmuletCtrl.ShopTableViewTradeAmuletData>
	{
		public enum AbilityCrestTradeTabType
		{
			PickUp = 0,
			Star3 = 3,
			Star4 = 4,
			Star5 = 5
		}

		public class ShopTableViewTradeAmuletData
		{
			public AbilityCrestTradeElement abilityCrest;

			public bool isLimitBreak;

			public bool isPickup;

			public UnitDetailModel.AmuletDetailData abilityCrestDataLevel1;

			public UnitDetailModel.AmuletDetailData abilityCrestDataWithLimitBreak;

			public bool isFirstMemoryCell;

			public int priority;

			public UnitDetailModel.AmuletDetailData abilityCrestData => null;
		}

		public float cellHeight;

		public float cellHeaderHeight;

		public float offsetHeight;

		[SerializeField]
		private AnimationListOneCol listAnimation;

		[SerializeField]
		private float delayFrame;

		[SerializeField]
		private AbilityCrestTradeTabType tabType;

		private List<ulong> abilityCrestIds;

		public List<ulong> originalAbilityCrestIds
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CommonTagSearchModel tagSearchModel
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isLimitBreak
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

		public DragEventScrollRect scrollViewScrollRect
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float ScrollViewPosY
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public event Action<int> updateTabDataEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected override void Awake()
		{
		}

		public void Init()
		{
		}

		private void InitTableData()
		{
		}

		public CommonSortModel.Preset GetFilterPreset()
		{
			return default(CommonSortModel.Preset);
		}

		protected void OnModelChangedForInputFilter()
		{
		}

		public void ReloadTableviewContents()
		{
		}

		public void ApplyAbilityListToTableData(List<ulong> abilityIdList, bool updateInputModel)
		{
		}

		public void SwitchContents()
		{
		}

		protected override TableViewCell<ShopTableViewTradeAmuletData> CreateCellForIndex(int index)
		{
			return null;
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		public void StartEnterAnimation()
		{
		}

		public void StartExitAnimation()
		{
		}

		public void UpdateTableview()
		{
		}

		protected override void UpdateContents()
		{
		}
	}
}
