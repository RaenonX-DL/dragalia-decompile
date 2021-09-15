/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EquipUnitListController : CommonDualListTableViewController
	{
		// Fields
		[SerializeField]
		private Vector2 weaponListCellSize;
		private WeaponListCellData outButtonData;
		private SkillListCellData skillOutButtonData;
		private AmuletInfoListCellData amuletOutButtonData;
		private int targetCrestId;
		private int targetCrestSlotIndex;
		private int equippedCrestId;
		private int[,] equippedCrestIds;
		private bool isSupportFriend;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public EquipUnitListController __4__this;
			public TableViewCell<CommonIconListCellData> cell;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _CreateCellForIndex_b__0(int cellIndex);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<CommonIconListCellData> __9__37_0;
			public static Func<CommonIconListCellData, CommonIconListCaption.CaptionInfo> __9__37_2;
			public static Predicate<CommonIconListCellData> __9__37_4;
			public static Func<List<CommonIconListCellData>, IEnumerable<CommonIconListCellData>> __9__37_5;
			public static Predicate<CommonIconListCellData> __9__37_8;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _CustomSort_b__37_0(CommonIconListCellData e);
			internal CommonIconListCaption.CaptionInfo _CustomSort_b__37_2(CommonIconListCellData e);
			internal bool _CustomSort_b__37_4(CommonIconListCellData e);
			internal IEnumerable<CommonIconListCellData> _CustomSort_b__37_5(List<CommonIconListCellData> e);
			internal bool _CustomSort_b__37_8(CommonIconListCellData e);
		}
	
		// Constructors
		public EquipUnitListController();
	
		// Methods
		protected override void Awake();
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
		private bool _CustomSort_b__37_1(List<CommonIconListCellData> dataList);
		[CompilerGenerated]
		private bool _CustomSort_b__37_6(CommonIconListCellData e);
		[CompilerGenerated]
		private bool _CustomSort_b__37_3(CommonIconListCellData e);
		[CompilerGenerated]
		private bool _CustomSort_b__37_7(CommonIconListCellData e);
	}
}
