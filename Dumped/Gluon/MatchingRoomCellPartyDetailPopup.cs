using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class MatchingRoomCellPartyDetailPopup : PopupBase
	{
		[SerializeField]
		private MatchingRoomCellPartyDetailPopupCell[] cells;

		[SerializeField]
		private GameObject raidBoostButton;

		[SerializeField]
		private GameObject oneButtonObj;

		[SerializeField]
		private GameObject twoButtonObj;

		private ulong viewerId;

		private List<RaidBoostPopup.RaidBoostModel.CellData> raidBoostList;

		private List<RaidBoostPopup.RaidBoostModel.CellData> rareRaidBoostList;

		private const string popupPrefabPath = "Prefabs/OutGame/Matching/MatchingRoom/MatchingRoomCellPartyDetailPopup";

		public int questId
		{
			[CompilerGenerated]
			private get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private new void Start()
		{
		}

		public static MatchingRoomCellPartyDetailPopup CreateWithMatchingData(MatchingRoomPlayerData data)
		{
			return null;
		}

		private void InitWithMatchingData(MatchingRoomPlayerData data)
		{
		}

		public void OnPlayerInfoButton()
		{
		}

		public void OnCloseButton()
		{
		}

		public void OnPressedRaidPowerButton()
		{
		}
	}
}
