using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyEquipSetPopupCell : MonoBehaviour
	{
		public Text nameText;

		public CommonUnitIcon weaponIcon;

		public CommonUnitIcon dragonIcon;

		public GameObject dragonEmptyIconObject;

		public CommonUnitIcon[] crestIcons;

		public GameObject[] crestEmptyIconObjects;

		public Image[] unionIcons;

		public CommonUnitIcon talismanIcon;

		public GameObject talismanEmptyIconObject;

		public Action<int> selectCallBack;

		public Action<int, string> registCallBack;

		private int charaId;

		private int dataIndex;

		private bool isEquipData;

		private bool isRegistPopupCellData;

		public void SetupSetDataCell(int charaId, int index, bool isRegistPopupCellData = false)
		{
		}

		public void SetupEquipDataCell(int charaId)
		{
		}

		private void SetupCellIcons(int charaId, int weaponId, ulong dragonKeyId, int[] crestIds, ulong talismanKeyId)
		{
		}

		public void OnNameEditButtonPressed()
		{
		}

		public void OnRegistButtonPressed()
		{
		}

		public void OnSelectButtonPressed()
		{
		}

		public void OnDetailButtonPressed()
		{
		}

		public void OnDragonIconPressed()
		{
		}

		public void OnWeaponIconPressed()
		{
		}

		public void OnCrestIconPressed(int tag)
		{
		}

		public void OnTalismanIconPressed()
		{
		}
	}
}
