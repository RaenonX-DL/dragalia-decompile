using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class PartyDetailPopup : CommonPopup
	{
		public GameObject editPartyNameButtonObject;

		public GameObject eventBonusButtonObject;

		public PartySelectPopupCell[] selectPopupCells;

		public Action ReladPartyNameAction;

		private int questId;

		private int partyIndex;

		private List<EventBonusPopup.EventBonusCharaInfo> eventAbilityInfo;

		public static PartyDetailPopup Create()
		{
			return null;
		}

		public void InitPopup(int questId, int partyIndex, [Optional] PartyList clearParty)
		{
		}

		public void OnEditPartyNameButtonPressed()
		{
		}

		public void OnEventBonusIconPressed()
		{
		}
	}
}
