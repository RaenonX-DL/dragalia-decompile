using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyChangePopup : CommonPopup
	{
		public TabBase partyGroupTab;

		public Transform listParentTransform;

		public GameObject originCell;

		private PartyChangePopupCell[] cells;

		public Text popupTopText;

		public Action<int, bool> partyChangeAction;

		public Action<int, bool> partyCopyAction;

		public Action<int, PartyList> partySetAction;

		private int nowGroupIndex;

		private int nowPartyIndex;

		private int selectGroupIndex;

		private int clearPartySampleDataIndex;

		private PartyList questClearParty;

		public static PartyChangePopup Create()
		{
			return null;
		}

		public void InitPopup(int questId, int partyGroupIndex = -1, int partyIndex = -1, bool isHideCopyButton = false)
		{
		}

		public void InitPopup(int sampleDataIndex, int indexInParty)
		{
		}

		public override void StartShowAnimation([Optional] UnityEvent onCompleted)
		{
		}

		private void OnSelectedGroupTab(int index)
		{
		}

		private void ReloadCell()
		{
		}

		private void ChangeButtonAction(int partyIndex)
		{
		}

		private void CopyButtonAction(int partyIndex)
		{
		}

		private void OnQuestClearPartyPopDetailButtonPressed(int questId, int partyIndex)
		{
		}

		private void CreateQuestClearPartyData(int indexInParty)
		{
		}

		private void CreateQuestClearPartyData()
		{
		}

		private PartySettingList CreateEquipableClearPartyUnitData(AtgenArchivePartyUnitList unitList, Dictionary<int, int> weaponDict, Dictionary<int, int> dragonDict, Dictionary<int, int> crestDict, List<ulong> equipDragonKeyIds)
		{
			return null;
		}

		private void SetButtonAction(int partyIndex)
		{
		}
	}
}
