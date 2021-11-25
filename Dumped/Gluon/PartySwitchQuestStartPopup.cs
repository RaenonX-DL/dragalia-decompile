using System.Text;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class PartySwitchQuestStartPopup : CommonPopup
	{
		private int questId;

		[SerializeField]
		private GameObject baseCell;

		[SerializeField]
		private Transform cellParent;

		private PartySettingList[] questClearParty;

		private PartySwitchPopupCell[] cellList;

		private const int partySwitchPartyCount = 2;

		public static PartySwitchQuestStartPopup Create(int questId)
		{
			return null;
		}

		private void SetupCells()
		{
		}

		private void CheckMask()
		{
		}

		public void OnPressStartQuest()
		{
		}

		private void GoToIngame()
		{
		}

		private void OnJoinConditionsFailed(StringBuilder failedDescription)
		{
		}

		private void OnTemporaryCharaInParty()
		{
		}

		public override void OnCloseButtonPressed()
		{
		}
	}
}
