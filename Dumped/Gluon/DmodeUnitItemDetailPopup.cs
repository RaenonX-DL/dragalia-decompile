using UnityEngine;

namespace Gluon
{
	public class DmodeUnitItemDetailPopup : PopupBase
	{
		private static readonly string prefabPath;

		[SerializeField]
		[Header("Control")]
		private GameObject equipButtonGO;

		[SerializeField]
		private GameObject switchButtonGO;

		[SerializeField]
		private GameObject sellButtonGO;

		[SerializeField]
		[Header("OnOffs")]
		private GameObject[] weaponGOs;

		[SerializeField]
		private GameObject[] abilityCrestGOs;

		[SerializeField]
		[Header("Content")]
		private DmodeUnitItemDetailInfoCell cell;

		private DmodeDungeonItemManager.ContainerType containerType;

		private DmodeDungeonItemType type;

		private int id;

		private int equipIndex;

		public static DmodeUnitItemDetailPopup Create(DmodeDungeonItemManager.ContainerType containerType, int id, bool canChangeEquip, bool canSell, bool canSwitch, int equipIndex = 0, ElementalType elementalType = ElementalType.NOELEMENT)
		{
			return null;
		}

		public static DmodeUnitItemDetailPopup CreateWithTypeAndItemId(DmodeDungeonItemType type, int itemId, int equipIndex = 0, bool canChangeEquip = true, ElementalType elementalType = ElementalType.NOELEMENT)
		{
			return null;
		}

		private void Initialize(DmodeDungeonItemManager.ContainerType containerType, DmodeDungeonItemType type, int id, int itemId, bool canChangeEquip, int equipIndex, bool canSell, bool canSwitch, ElementalType elementalType)
		{
		}

		public void OnEquipButtonPressed()
		{
		}

		public void OnSwitchButtonPressed()
		{
		}

		public void OnSellButtonPressed()
		{
		}
	}
}
