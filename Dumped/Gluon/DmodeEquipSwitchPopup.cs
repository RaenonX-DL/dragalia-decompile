using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeEquipSwitchPopup : PopupBase
	{
		[SerializeField]
		[Header("Control")]
		public GameObject[] weaponGOs;

		public GameObject[] abilityCrestGOs;

		[SerializeField]
		[Header("Cells")]
		public DmodeUnitItemDetailSwitchInfoCell cell;

		public Transform slotParent;

		[SerializeField]
		[Header("Bottom")]
		public Text beforePointText;

		public Text afterPointText;

		public Text beforeRarePointText;

		public Text afterRarePointText;

		public GameObject sellWarning;

		public static readonly string prefabPathAbilityCrest;

		public static readonly string prefabPathWeapon;

		private DmodeDungeonItemManager.ContainerType containerType;

		private DmodeDungeonItemType type;

		private int afterId;

		private List<DmodeUnitItemDetailSwitchInfoCell> slotCells;

		private int selectedIndex;

		public static DmodeEquipSwitchPopup Create(DmodeDungeonItemType type, DmodeDungeonItemManager.ContainerType containerType, int id)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void OnCellPressed(int index)
		{
		}

		public void OnOKButtonPressed()
		{
		}
	}
}
