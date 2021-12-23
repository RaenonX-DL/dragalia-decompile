using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyCrestSetPopupCell : MonoBehaviour
	{
		public Text setName;

		public CommonUnitIcon[] commonUnitIcons;

		public GameObject[] emptyIconObjects;

		public Image[] unionIcons;

		public CommonUnitIcon talismanIcon;

		public GameObject emptyTalismanIconObject;

		public Action<int> selectCallBack;

		public Action<int> registCallBack;

		public GameObject detailButtonObject;

		private int setIndex;

		private bool isSelectableCell;

		private bool isEquipData;

		public void InitCellByEquipData(int index)
		{
		}

		public void UpdateCell(int index, bool canSelect = true)
		{
		}

		public void OnEditNameButtonPressed()
		{
		}

		public void OnDetailButtonPressed()
		{
		}

		public void OnRegistButtonPressed()
		{
		}

		public void OnSelectButtonPressed()
		{
		}

		private void SendCrestSetName(int index, string name)
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
