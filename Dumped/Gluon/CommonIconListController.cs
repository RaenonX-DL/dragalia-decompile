using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Gluon
{
	public class CommonIconListController : TableViewController<CommonIconListCellData>
	{
		public float cellWidth;

		public float cellHeight;

		public CommonIconListBase iconListBase;

		public bool addOutButton;

		[SerializeField]
		[Header("Empty Text")]
		[FormerlySerializedAs("emptyDragonMessage")]
		public Text emptyMessage;

		[SerializeField]
		[Header("Empty due to filter")]
		public Text emptyDueToFilterMessage;

		private const int paddingBottomLayoutHeight = 80;

		public virtual void LoadData(CommonIconListType type, ulong[] originalKeyIds, ulong[] dataKeyIds, int[] decorationNums, CommonIconListCaption.CaptionInfo[] captions)
		{
		}

		public void Reload()
		{
		}

		public void ClearList()
		{
		}

		public void ShowEmptyMessage(CommonIconListType type)
		{
		}

		protected virtual CommonIconListCellData CreateCharacterCellData(int keyIdOrInvalidId, int decoNum)
		{
			return null;
		}

		protected virtual CommonIconListCellData CreateDragonCellData(ulong keyIdOrInvalidId, int decoNum)
		{
			return null;
		}

		protected virtual CommonIconListCellData CreateWeaponCellData(ulong keyIdOrInvalidId, int decoNum)
		{
			return null;
		}

		protected virtual CommonIconListCellData CreateAmuletCellData(ulong keyIdOrInvalidId, int decoNum)
		{
			return null;
		}

		protected virtual CommonIconListCellData CreateSkillCellData(ulong keyIdOrInvalidId, int decoNum)
		{
			return null;
		}

		protected virtual CommonIconListCellData CreateWeaponPassiveAbilityCellData(ulong keyIdOrInvalidId, int decoNum)
		{
			return null;
		}

		protected virtual int ListDefaultSort(CommonIconListCellData currCell, CommonIconListCellData nextCell)
		{
			return default(int);
		}

		protected override TableViewCell<CommonIconListCellData> CreateCellForIndex(int index)
		{
			return null;
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		protected override float GetCellWidthAtIndex(int index)
		{
			return default(float);
		}

		protected void SetCellSize(float width, float height)
		{
		}

		protected T SetupCharacterCellBaseData<T>(int keyId, int decoNum) where T : CommonIconListCellData, new()
		{
			return null;
		}

		protected T SetupDragonCellBaseData<T>(ulong keyId, int decoNum) where T : CommonIconListCellData, new()
		{
			return null;
		}

		protected T SetupWeaponCellBaseData<T>(ulong keyId, int decoNum) where T : CommonIconListCellData, new()
		{
			return null;
		}

		protected T SetupAmuletCellBaseData<T>(ulong keyId, int decoNum) where T : CommonIconListCellData, new()
		{
			return null;
		}

		protected T SetupSkillCellBaseData<T>(ulong keyId, int decoNum) where T : SkillListCellData, new()
		{
			return null;
		}

		protected T SetupWeaponPassiveAbilityCellBaseData<T>(ulong passiveAbilityId, int decoNum) where T : WeaponPassiveAbilityListCellData, new()
		{
			return null;
		}

		protected virtual void SetupOutButton(CommonIconListType listType)
		{
		}

		private int GetMaxListCount(CommonIconListType type)
		{
			return default(int);
		}

		protected bool CheckEquipTarget(CommonIconListType type, ulong keyId)
		{
			return default(bool);
		}

		protected bool CheckSupportCharaEquip(CommonIconListType type, ulong keyId)
		{
			return default(bool);
		}

		protected bool CheckPartyChara(int charaId)
		{
			return default(bool);
		}

		public void ReloadCellByUpdateFlag()
		{
		}

		protected virtual void AddExceptionButton(CommonIconListType type)
		{
		}

		protected virtual void CustomSort()
		{
		}

		public void SetSelectCell(CommonIconListCellData data, CommonIconListCellData.State state, bool setUpdateFlag)
		{
		}

		public void SetLockIcon(ulong keyId, [Optional] Action iconLockCallBack)
		{
		}
	}
}
