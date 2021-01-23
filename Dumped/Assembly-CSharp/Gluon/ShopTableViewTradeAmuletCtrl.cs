/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopTableViewTradeAmuletCtrl : TableViewController<Gluon.ShopTableViewTradeAmuletCtrl.ShopTableViewTradeAmuletData>
	{
		// Fields
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
		[CompilerGenerated]
		private List<ulong> _originalAbilityCrestIds_k__BackingField;
		[CompilerGenerated]
		private CommonTagSearchModel _tagSearchModel_k__BackingField;
		[CompilerGenerated]
		private Action<int> updateTabDataEvent;
		[CompilerGenerated]
		private bool _isLimitBreak_k__BackingField;
		[CompilerGenerated]
		private DragEventScrollRect _scrollViewScrollRect_k__BackingField;
	
		// Properties
		public List<ulong> originalAbilityCrestIds { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CommonTagSearchModel tagSearchModel { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isLimitBreak { [CompilerGenerated] get; [CompilerGenerated] set; }
		public DragEventScrollRect scrollViewScrollRect { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float ScrollViewPosY { get; set; }
	
		// Events
		public event Action<int> updateTabDataEvent {
			add;
			remove;
		}
	
		// Nested types
		public enum AbilityCrestTradeTabType
		{
			PickUp = 0,
			Star3 = 3,
			Star4 = 4,
			Star5 = 5
		}
	
		public class ShopTableViewTradeAmuletData
		{
			// Fields
			public AbilityCrestTradeElement abilityCrest;
			public bool isLimitBreak;
			public bool isPickup;
			public UnitDetailModel.AmuletDetailData abilityCrestDataLevel1;
			public UnitDetailModel.AmuletDetailData abilityCrestDataWithLimitBreak;
			public bool isFirstMemoryCell;
			public int priority;
	
			// Properties
			public UnitDetailModel.AmuletDetailData abilityCrestData { get; }
	
			// Constructors
			public ShopTableViewTradeAmuletData();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<ShopTableViewTradeAmuletData, int> __9__37_0;
			public static Func<ShopTableViewTradeAmuletData, int> __9__37_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _ApplyAbilityListToTableData_b__37_0(ShopTableViewTradeAmuletData x);
			internal int _ApplyAbilityListToTableData_b__37_1(ShopTableViewTradeAmuletData x);
		}
	
		// Constructors
		public ShopTableViewTradeAmuletCtrl();
	
		// Methods
		protected override void Awake();
		public void Init();
		private void InitTableData();
		public CommonSortModel.Preset GetFilterPreset();
		protected void OnModelChangedForInputFilter();
		public void ReloadTableviewContents();
		public void ApplyAbilityListToTableData(List<ulong> abilityIdList, bool updateInputModel);
		public void SwitchContents();
		protected override TableViewCell<ShopTableViewTradeAmuletData> CreateCellForIndex(int index);
		protected override float GetCellHeightAtIndex(int index);
		public void StartEnterAnimation();
		public void StartExitAnimation();
		public void UpdateTableview();
		protected override void UpdateContents();
	}
}
