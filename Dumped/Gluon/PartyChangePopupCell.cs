using System;
using System.Runtime.InteropServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyChangePopupCell : MonoBehaviour
	{
		public Image elementIcon;

		public Text partyName;

		public Text partyPower;

		public CommonUnitIcon[] commonUnitIcons;

		public GameObject[] emptyIconObjects;

		public Button changeButton;

		public Button copyButton;

		public Button setButton;

		public Action<int> setCallBack;

		public Action registButtonAction;

		public Action<int, int> detailButtonAction;

		protected int questId;

		private int partyIndex;

		private Action<int> changeCallBack;

		private Action<int> copyCallBack;

		private PartyList questClearPartyList;

		private static readonly int maxSlotGroupCount;

		public void SetupCellData(int questId)
		{
		}

		public void UpdateCell(int partyIndex, Action<int> changeCallBack, Action<int> copyCallBack, [Optional] PartyList partyList)
		{
		}

		protected virtual void OnDetailButtonPressed()
		{
		}

		public void OnRegistPopupCellQuestClearPrtyDetailPressed()
		{
		}

		public void OnRegistPopupCellDetailPressed()
		{
		}

		public void OnChangeButtonPressed()
		{
		}

		protected virtual void OnCharaIconPressed(int tag)
		{
		}

		public void OnCopyButtonPressed()
		{
		}

		public void OnSetButtonPressed()
		{
		}

		public void SetDispClearPartySetButton(bool isShow)
		{
		}

		private int GetQuestClearPartyPowerParam(SearchClearPartyList searchQuestClearPartyList)
		{
			return default(int);
		}
	}
}
