/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[RequireComponent]
	public class CommonIconListController : TableViewController<Gluon.CommonIconListCellData>
	{
		// Fields
		public float cellWidth;
		public float cellHeight;
		public CommonIconListBase iconListBase;
		public bool addOutButton;
		[FormerlySerializedAs]
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text emptyMessage;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text emptyDueToFilterMessage;
		private const int paddingBottomLayoutHeight = 80;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public CommonIconListController __4__this;
			public TableViewCell<CommonIconListCellData> cell;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _CreateCellForIndex_b__0(int cellIndex);
			internal void _CreateCellForIndex_b__1(int cellIndex);
		}
	
		// Constructors
		public CommonIconListController();
	
		// Methods
		public virtual void LoadData(CommonIconListType type, ulong[] originalKeyIds, ulong[] dataKeyIds, int[] decorationNums, CommonIconListCaption.CaptionInfo[] captions);
		public void Reload();
		public void ClearList();
		public void ShowEmptyMessage(CommonIconListType type);
		protected virtual CommonIconListCellData CreateCharacterCellData(int keyIdOrInvalidId, int decoNum);
		protected virtual CommonIconListCellData CreateDragonCellData(ulong keyIdOrInvalidId, int decoNum);
		protected virtual CommonIconListCellData CreateWeaponCellData(ulong keyIdOrInvalidId, int decoNum);
		protected virtual CommonIconListCellData CreateAmuletCellData(ulong keyIdOrInvalidId, int decoNum);
		protected virtual CommonIconListCellData CreateSkillCellData(ulong keyIdOrInvalidId, int decoNum);
		protected virtual CommonIconListCellData CreateWeaponPassiveAbilityCellData(ulong keyIdOrInvalidId, int decoNum);
		protected virtual int ListDefaultSort(CommonIconListCellData currCell, CommonIconListCellData nextCell);
		protected override TableViewCell<CommonIconListCellData> CreateCellForIndex(int index);
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
		protected void SetCellSize(float width, float height);
		protected T SetupCharacterCellBaseData<T>(int keyId, int decoNum)
			where T : CommonIconListCellData, new();
		protected T SetupDragonCellBaseData<T>(ulong keyId, int decoNum)
			where T : CommonIconListCellData, new();
		protected T SetupWeaponCellBaseData<T>(ulong keyId, int decoNum)
			where T : CommonIconListCellData, new();
		protected T SetupAmuletCellBaseData<T>(ulong keyId, int decoNum)
			where T : CommonIconListCellData, new();
		protected T SetupSkillCellBaseData<T>(ulong keyId, int decoNum)
			where T : SkillListCellData, new();
		protected T SetupWeaponPassiveAbilityCellBaseData<T>(ulong passiveAbilityId, int decoNum)
			where T : WeaponPassiveAbilityListCellData, new();
		protected virtual void SetupOutButton(CommonIconListType listType);
		private int GetMaxListCount(CommonIconListType type);
		protected bool CheckEquipTarget(CommonIconListType type, ulong keyId);
		protected bool CheckSupportCharaEquip(CommonIconListType type, ulong keyId);
		protected bool CheckPartyChara(int charaId);
		public void ReloadCellByUpdateFlag();
		protected virtual void AddExceptionButton(CommonIconListType type);
		protected virtual void CustomSort();
		public void SetSelectCell(CommonIconListCellData data, CommonIconListCellData.State state, bool setUpdateFlag);
		public void SetLockIcon(ulong keyId, Action iconLockCallBack = null);
	}
}
