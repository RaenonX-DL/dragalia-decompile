using UnityEngine;

namespace Gluon
{
	public class FriendSupportListController : CommonDualListTableViewController
	{
		[SerializeField]
		private Vector2 weaponListCellSize;

		private WeaponListCellData outButtonData;

		[SerializeField]
		private FriendSupportSettingView settingView;

		protected override CommonIconListCellData CreateCharacterCellData(int keyIdOrInvalidId, int decoNum)
		{
			return null;
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

		protected override void SetupOutButton(CommonIconListType listType)
		{
		}

		public CommonIconListCellData GetCellDataByKeyId(ulong keyId)
		{
			return null;
		}

		public void SetupWeaponOutButtonData(WeaponType defaultWeaponType)
		{
		}

		public void SetOutButtonState(bool isSelected)
		{
		}

		public void SetLock(CommonEquipIconCellData data, bool isLock)
		{
		}

		public void SetSelectLock(FriendSupportListCellData data, bool isSelect)
		{
		}
	}
}
