using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyEquipCrestSelectPopup : CommonPopup
	{
		[SerializeField]
		private GameObject type1Slot;

		[SerializeField]
		private GameObject type2Slot;

		[SerializeField]
		private GameObject type3Slot;

		[SerializeField]
		private GameObject crestCellObj;

		[SerializeField]
		private PartyEquipTalisman talismanCell;

		[SerializeField]
		private Image crestIcon;

		[SerializeField]
		private GameObject crestFavoriteIcon;

		[SerializeField]
		private CommonUnionIcon crestUnionIcon;

		[SerializeField]
		private Text releaseCount;

		[SerializeField]
		private Text ability;

		[SerializeField]
		private Image unionIcon;

		[SerializeField]
		private GameObject emptyObject;

		[SerializeField]
		private GameObject crestInfoObject;

		[SerializeField]
		private Text listSwitchButtonText;

		[SerializeField]
		private Image emptyIcon;

		[SerializeField]
		private GameObject outButtonOject;

		[SerializeField]
		private GameObject noneUnionGameObject;

		[SerializeField]
		private GameObject eventBonusObject;

		[SerializeField]
		private EquipUnitListController equipUnitListController;

		[SerializeField]
		private CommonIconListBase iconListBase;

		private int crestId;

		private AblitiyCrestSlotType slotType;

		private int slotIndex;

		private bool isSupportFriend;

		private int selectedCrestId;

		private ulong talismanKeyId;

		private ulong selectedTalismanId;

		private bool isTalismanList;

		public static PartyEquipCrestSelectPopup Create()
		{
			return null;
		}

		public void Setup(int slotIndex, int slotType, int crestId, bool isSupportFriend = false)
		{
		}

		private void RefreshEquippedCrest()
		{
		}

		public void Setup(ulong talismanKeyId, bool isSupportFriend = false)
		{
		}

		private void OnIconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void OnTalismanIconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void SelectEquipUnit(CommonEquipIconCellData equipData)
		{
		}

		private void SelectEquipIconCellData(ulong keyId, CommonEquipIconCellData equipData, bool hasOutButtonSelectState)
		{
		}

		private void OnIconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void OnTalismanIconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		public void OnOutButtonPressed()
		{
		}

		public void OnTalismanOutButtonPressed()
		{
		}

		private void InitList()
		{
		}

		private void InitTalismanList()
		{
		}

		private void SetupSlot(int slotType)
		{
		}

		private void OnSortButtonClicked()
		{
		}

		private List<ulong> InsertActiveEquipmentToFilteredList(List<ulong> filteredList)
		{
			return null;
		}

		public void OnListChangeButtonPressed()
		{
		}

		public int GetSelectedCrestId()
		{
			return default(int);
		}

		public ulong GetSelectedTalismanId()
		{
			return default(ulong);
		}
	}
}
