using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class WeaponSkinSelectListController : TableViewController<CommonIconListCellData>
	{
		public float cellWidth;

		public float cellHeight;

		public UnityAction<CommonIconListCellData, TableViewCell<CommonIconListCellData>> listButtonCallBack;

		public UnityAction<CommonIconListCellData, TableViewCell<CommonIconListCellData>> listButtonLongCallBack;

		public UnityAction outButtonCallBack;

		public CommonIconListBase iconListBase;

		public bool isBattleRoyalSkin;

		[HideInInspector]
		public WeaponType listWeaponType;

		private int nowWeaponSkinId;

		private const int paddingBottomLayoutHeight = 80;

		public int CellCount => default(int);

		public void LoadSkinData(int[] weaponSkinIds)
		{
		}

		protected override TableViewCell<CommonIconListCellData> CreateCellForIndex(int index)
		{
			return null;
		}

		public void SetSelectCell(CommonIconListCellData data, CommonIconListCellData.State state, bool setUpdateFlag)
		{
		}

		public void ReloadCellByUpdateFlag()
		{
		}

		public CommonIconListCellData GetSelectData()
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
	}
}
