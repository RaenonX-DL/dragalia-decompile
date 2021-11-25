using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PartySwitchPopupCell : PartyChangePopupCell
	{
		public Button historyButton;

		[SerializeField]
		private Text historyButtonText;

		public GameObject[] MaskList;

		[SerializeField]
		private GameObject limitedElementBalloon;

		[SerializeField]
		private Image limitedElementIcon;

		private bool isUseClearParty;

		private int cellIndex;

		private int partyIndex;

		private PartySwitchLocation partySwitchLocation;

		private Action<int, int, bool> formationAction;

		private Action<int, int> partyChangeAction;

		private Action<int> copyPartyAction;

		private Action historyButtonAction;

		private Action updatePartyNamesAction;

		public void SetupCellData(PartySwitchLocation location, int questId, int partyIndex, int cellIndex, [Optional] Action<int, int, bool> formationAction, [Optional] Action<int, int> partyChangeAction, [Optional] Action<int> copyPartyAction, [Optional] Action historyButtonAction, [Optional] Action updatePartyNamesAction)
		{
		}

		public void SetParty(int partyIndex)
		{
		}

		public void SetLimitedElementBalloon(ElementalType elementalType)
		{
		}

		public void OnFormationButtonPressed()
		{
		}

		public void OnHistoryButtonPressed()
		{
		}

		private void CheckLostUnit(int cellIndex)
		{
		}

		public void OnPartyChangeButtonPressed()
		{
		}

		private void ChangeButtonAction(int selectPartyIndex)
		{
		}

		protected override void OnDetailButtonPressed()
		{
		}

		protected override void OnCharaIconPressed(int tag)
		{
		}
	}
}
