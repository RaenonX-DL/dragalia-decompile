using System;
using System.Runtime.InteropServices;
using System.Text;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PartySwitchPopup : CommonPopup
	{
		private Action gotoPrepareSceneAction;

		private Action okButtonAction;

		private int questId;

		[SerializeField]
		private GameObject baseCell;

		[SerializeField]
		private Transform cellParent;

		[SerializeField]
		private RectTransform scrollViewRect;

		[SerializeField]
		private Text multiText;

		private PartySettingList[] questClearParty;

		private PartySwitchPopupCell[] cellList;

		public const int partySwitchPartyCount = 2;

		private QuestPartySwitchModel partySwitchModel;

		private GameObject parentObject;

		private PartySwitchLocation partySwitchLocation;

		private Action UpdatePartyNameAction;

		public static PartySwitchPopup Create(PartySwitchLocation location, GameObject parentObject, int questId, Action gotoPrepareSceneAction, bool isRequestClearParty)
		{
			return null;
		}

		public static PartySwitchPopup CreateForChangeParty(PartySwitchLocation location, GameObject parentObject, int questId, Action gotoPrepareSceneAction, bool isRequestClearParty, [Optional] Action onOkPressed, [Optional] Action UpdatePartyNameAction)
		{
			return null;
		}

		public static PartySwitchPopup CreateForMulti(PartySwitchLocation location, GameObject parentObject, int questId, Action gotoPrepareSceneAction, Action matchingAction, bool isRequestClearParty)
		{
			return null;
		}

		private void SetupCells(bool isRequestClearParty)
		{
		}

		private void CheckMask()
		{
		}

		private void UpdatePartyName()
		{
		}

		private void OnQuestGetQuestClearPartySuccess(QuestGetQuestClearPartyResponse res)
		{
		}

		private void FromationButtonAction(int partyIndex, int cellIndex, bool isClearParty)
		{
		}

		private void ChangeButtonAction(int partyIndex, int cellIndex)
		{
		}

		private void CopyButtonAction(int cellIndex)
		{
		}

		public void OnPressStartQuest()
		{
		}

		private void StartSoloQuest()
		{
		}

		private void CheckStartQuest(Action onCheckSuccess)
		{
		}

		public override void OnOkButtonPressed()
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

		private void ShowMultiText(bool bShow)
		{
		}

		private void SetOKButtonText(PartySwitchLocation location)
		{
		}
	}
}
