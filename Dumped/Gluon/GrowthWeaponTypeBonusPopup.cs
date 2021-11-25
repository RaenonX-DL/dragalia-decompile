using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class GrowthWeaponTypeBonusPopup : CommonPopup
	{
		private class WeaponTypeBonusPopupListData
		{
			public int weaponId;

			public int seriesId;

			public int seriesSortId;

			public WeaponTypeBonusPopupListData(int weaponId, int seriesId)
			{
			}
		}

		public TabBase weaponTypeTabBase;

		public Transform listParentTransform;

		public GameObject emptyTextObject;

		private int tabIndex;

		private List<WeaponTypeBonusPopupListData> bonusWeaponList;

		public static GrowthWeaponTypeBonusPopup Create()
		{
			return null;
		}

		public void InitPopup(int defaultTabIndex = 1)
		{
		}

		public void OnTabSelected(int index)
		{
		}

		private void ReloadList()
		{
		}

		private void SetBonusWeaponList(WeaponType type)
		{
		}
	}
}
