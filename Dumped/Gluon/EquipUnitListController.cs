using UnityEngine;

namespace Gluon
{
	public class EquipUnitListController : CommonDualListTableViewController
	{
		[SerializeField]
		private Vector2 weaponListCellSize;

		private WeaponListCellData outButtonData;

		private SkillListCellData skillOutButtonData;

		private AmuletInfoListCellData amuletOutButtonData;

		private int targetCrestId;

		private int targetCrestSlotIndex;

		private int equippedCrestId;

		private int[,] equippedCrestIds;

		private ulong targetTalismanKeyId;

		private ulong equippedTalismanKeyId;

		private bool isSupportFriend;

		protected override void Awake()
		{
		}

		private int GetEquippedCrestId(int charaIndex, int slotIndex)
		{
			return default(int);
		}

		public void SetTargetCrest(int slotIndex, int crestId)
		{
		}

		public void SetTargetTalisman(ulong talismanKeyId)
		{
		}

		public void SetEquippedCrestId(int crestId)
		{
		}

		public void SetEquippedTalismanKeyId(ulong talismanKeyId)
		{
		}

		public void SetSupportFriend(bool isSupportFriend)
		{
		}

		protected override CommonIconListCellData CreateDragonCellData(ulong keyIdOrInvalidId, int decoNum)
		{
			return null;
		}

		protected override CommonIconListCellData CreateWeaponCellData(ulong keyIdOrInvalidId, int decoNum)
		{
			return null;
		}

		protected override CommonIconListCellData CreateAmuletCellData(ulong keyIdOrInvalidId, int decoNum)
		{
			return null;
		}

		protected override CommonIconListCellData CreateTalismanCellData(ulong keyIdOrInvalidId, int decoNum)
		{
			return null;
		}

		protected override CommonIconListCellData CreateSkillCellData(ulong keyIdOrInvalidId, int decoNum)
		{
			return null;
		}

		protected override void SetupOutButton(CommonIconListType listType)
		{
		}

		protected override TableViewCell<CommonIconListCellData> CreateCellForIndex(int index)
		{
			return null;
		}

		public CommonEquipIconCellData GetCellDataByKeyId(ulong keyId)
		{
			return null;
		}

		public void SetupWeaponOutButtonData(WeaponType defaultWeaponType)
		{
		}

		public void SetOutButtonState(bool isSelected)
		{
		}

		public void SetupSkillOutButtonData()
		{
		}

		public void SetupAmuletOutButtonData()
		{
		}

		public void ClearAmuletOutButtonData()
		{
		}

		private bool CheckCurrentPartyEquip(CommonIconListType type, ulong keyId)
		{
			return default(bool);
		}

		public void UpdateIconState()
		{
		}

		private static CommonIconListType GetCommonIconListType()
		{
			return default(CommonIconListType);
		}

		public void SetEquip(CommonEquipIconCellData data, bool isEquip)
		{
		}

		public void SetLock(CommonEquipIconCellData data, bool isLock, bool setUpdateFlag)
		{
		}

		public void SetSkin(bool isSkin)
		{
		}

		public void SetListCellButtonEnable(int index, bool isEnable)
		{
		}

		public static int GetWeaponEquippedCount(int weaponId)
		{
			return default(int);
		}

		public int GetDefaultWeaponEquippedCount(WeaponType weaponType)
		{
			return default(int);
		}

		public void UpdateWeaponOutButtonRemainingCount()
		{
		}

		public int GetCrestEquippedCount(int crestId)
		{
			return default(int);
		}

		protected override void CustomSort()
		{
		}

		private bool IsEquippedData(CommonIconListCellData data)
		{
			return default(bool);
		}

		public void UpdateEquippedCount(int crestId)
		{
		}

		public void OnOutButtonPressed()
		{
		}
	}
}
