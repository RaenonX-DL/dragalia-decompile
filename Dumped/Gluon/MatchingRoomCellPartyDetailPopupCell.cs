using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MatchingRoomCellPartyDetailPopupCell : MonoBehaviour
	{
		[SerializeField]
		[Header("Panel")]
		public CommonIcon characterIcon;

		public CommonIcon dragonIcon;

		public GameObject noDragonMark;

		public CommonIcon weaponIcon;

		public CommonIcon[] amuletIcon;

		public GameObject[] noAmuletMark;

		public CommonExAbilityCell[] exAbilityCells;

		[SerializeField]
		[Header("SortDeco")]
		public Transform charaDecoNode;

		public Transform dragonDecoNode;

		public Transform weaponDecoNode;

		public Transform[] amuletDecoNode;

		[SerializeField]
		[Header("Text")]
		public Text characterNameText;

		public Text plusValText;

		public Text manaCircleText;

		[SerializeField]
		private Text emptyAbilityCrestText;

		private MatchingRoomPlayerData data;

		private int memberIndex;

		private CommonIconListSortDeco charaDeco;

		private CommonIconListSortDeco dragonDeco;

		private CommonIconListSortDeco weaponDeco;

		private CommonIconListSortDeco[] amuletDeco;

		public void SetupWithMatchingDetailData(MatchingRoomPlayerData data, int memberIndex)
		{
		}

		private void InitWithData()
		{
		}

		private void SetAmulet(int index, UnitDetailModel.AmuletDetailData abilityCrestData, int slotNum, int maxSlotNum)
		{
		}
	}
}
