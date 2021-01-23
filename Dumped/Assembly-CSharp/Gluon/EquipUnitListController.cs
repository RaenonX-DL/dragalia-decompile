/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EquipUnitListController : CommonDualListTableViewController
	{
		// Fields
		[SerializeField]
		private Vector2 weaponListCellSize;
		[SerializeField]
		private CommonTagSearch tagSearch;
		private WeaponListCellData outButtonData;
		private SkillListCellData skillOutButtonData;
		private AmuletInfoListCellData amuletOutButtonData;
		private int targetCrestId;
		private int targetCrestSlotIndex;
		private int equippedCrestId;
		private int[,] equippedCrestIds;
		private bool isSupportFriend;
		protected List<CommonIconListCellData> originalTableData;
		[CompilerGenerated]
		private ulong[] _originalKeyIdList_k__BackingField;
		private bool preventOnModelChanged;
		private bool preventNextClearText;
	
		// Properties
		public ulong[] originalKeyIdList { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public List<int> filteredId;
			public Func<ulong, bool> __9__1;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal List<ulong> _OnInputFilterChanged_b__0(List<ulong> l);
			internal bool _OnInputFilterChanged_b__1(ulong x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0
		{
			// Fields
			public EquipUnitListController __4__this;
			public TableViewCell<CommonIconListCellData> cell;
	
			// Constructors
			public __c__DisplayClass31_0();
	
			// Methods
			internal void _CreateCellForIndex_b__0(int cellIndex);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<CommonIconListCellData> __9__49_0;
			public static Func<CommonIconListCellData, CommonIconListCaption.CaptionInfo> __9__49_2;
			public static Predicate<CommonIconListCellData> __9__49_4;
			public static Func<List<CommonIconListCellData>, IEnumerable<CommonIconListCellData>> __9__49_5;
			public static Predicate<CommonIconListCellData> __9__49_8;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _CustomSort_b__49_0(CommonIconListCellData e);
			internal CommonIconListCaption.CaptionInfo _CustomSort_b__49_2(CommonIconListCellData e);
			internal bool _CustomSort_b__49_4(CommonIconListCellData e);
			internal IEnumerable<CommonIconListCellData> _CustomSort_b__49_5(List<CommonIconListCellData> e);
			internal bool _CustomSort_b__49_8(CommonIconListCellData e);
		}
	
		// Constructors
		public EquipUnitListController();
	
		// Methods
		protected override void Awake();
		protected void OnModelChangedForInputFilter();
		private void OnInputFilterChanged(List<int> filteredId);
		private void ClearInputFilter();
		public override void OnListTypeReloaded();
		private int GetEquippedCrestId(int charaIndex, int slotIndex);
		public void SetTargetCrest(int slotIndex, int crestId);
		public void SetEquippedCrestId(int crestId);
		public void SetSupportFriend(bool isSupportFriend);
		protected override CommonIconListCellData CreateDragonCellData(ulong keyIdOrInvalidId, int decoNum);
		protected override CommonIconListCellData CreateWeaponCellData(ulong keyIdOrInvalidId, int decoNum);
		protected override CommonIconListCellData CreateAmuletCellData(ulong keyIdOrInvalidId, int decoNum);
		protected override CommonIconListCellData CreateSkillCellData(ulong keyIdOrInvalidId, int decoNum);
		protected override void SetupOutButton(CommonIconListType listType);
		protected override TableViewCell<CommonIconListCellData> CreateCellForIndex(int index);
		public CommonEquipIconCellData GetCellDataByKeyId(ulong keyId);
		public void SetupWeaponOutButtonData(WeaponType defaultWeaponType);
		public void SetOutButtonState(bool isSelected);
		public void SetupSkillOutButtonData();
		public void SetupAmuletOutButtonData();
		public void ClearAmuletOutButtonData();
		private bool CheckCurrentPartyEquip(CommonIconListType type, ulong keyId);
		public void UpdateIconState();
		private static CommonIconListType GetCommonIconListType();
		public void SetEquip(CommonEquipIconCellData data, bool isEquip);
		public void SetLock(CommonEquipIconCellData data, bool isLock, bool setUpdateFlag);
		public void SetSkin(bool isSkin);
		public void SetListCellButtonEnable(int index, bool isEnable);
		public static int GetWeaponEquippedCount(int weaponId);
		public int GetDefaultWeaponEquippedCount(WeaponType weaponType);
		public void UpdateWeaponOutButtonRemainingCount();
		public int GetCrestEquippedCount(int crestId);
		protected override void CustomSort();
		private bool IsEquippedData(CommonIconListCellData data);
		[CompilerGenerated]
		private bool _CustomSort_b__49_1(List<CommonIconListCellData> dataList);
		[CompilerGenerated]
		private bool _CustomSort_b__49_6(CommonIconListCellData e);
		[CompilerGenerated]
		private bool _CustomSort_b__49_3(CommonIconListCellData e);
		[CompilerGenerated]
		private bool _CustomSort_b__49_7(CommonIconListCellData e);
	}
}
