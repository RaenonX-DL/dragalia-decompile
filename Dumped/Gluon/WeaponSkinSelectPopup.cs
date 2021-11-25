using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class WeaponSkinSelectPopup : CommonPopup
	{
		[SerializeField]
		private Image nowEquipIcon;

		[SerializeField]
		private WeaponSkinSelectListController skinListController;

		[SerializeField]
		private GameObject emptyTextObj;

		private int equipWeaponId;

		private CommonIconListCellData nowSelectData;

		public static WeaponSkinSelectPopup Create(bool showBlackLayer = true)
		{
			return null;
		}

		public void InitPopup(int nowEquipWeaponId)
		{
		}

		private IEnumerator LoadSkinList()
		{
			return null;
		}

		private int[] CreateDataIdList()
		{
			return null;
		}

		public void OnSortButtonClicked()
		{
		}

		public void OnSortApplied()
		{
		}

		public int GetSelectWeaponSkinId()
		{
			return default(int);
		}

		private void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void OutButtonPressed()
		{
		}

		private void OnIconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}
	}
}
