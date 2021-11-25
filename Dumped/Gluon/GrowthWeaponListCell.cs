using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthWeaponListCell : MonoBehaviour
	{
		public CommonUnitIcon unitIcon;

		public Text weaponName;

		public Text weaponHp;

		public Text weaponAtk;

		public Text hasCount;

		public Text releaseCount;

		public GameObject redLabelObject;

		public GameObject blackLabelObject;

		public GameObject lockCellObject;

		public GameObject completeImageObject;

		public Badge growBadge;

		public GameObject[] slotIconsTypeA;

		public GameObject[] slotIconsTypeB;

		public GameObject[] slotIconsTypeC;

		public Action<int> cellPressCallBack;

		private int weaponId;

		public void InitCell(int weaponId)
		{
		}

		public void UpdateCell()
		{
		}

		public void OnCellPressed()
		{
		}

		public void OncellLongPressed()
		{
		}
	}
}
