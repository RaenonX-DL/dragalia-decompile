using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class PartyCrestSetDetailPopup : CommonPopup
	{
		public PartyEquipCrest[] crestCells;

		public PartyEquipTalisman talismanCell;

		public GameObject errorTextObject;

		public GameObject unionBonusButtonObject;

		public GameObject eventBonusButtonObject;

		private List<EventBonusPopup.EventBonusCharaInfo> eventAbilityInfo;

		private List<UnionBonusPopup.UnionBonusInfo> unionBonusCharaInfoList;

		public static PartyCrestSetDetailPopup Create()
		{
			return null;
		}

		public void InitPopup(int setIndex, bool canSelectCrestSet = true, bool isEquipData = false)
		{
		}

		protected override void Start()
		{
		}

		public void OnEventButtonPressed()
		{
		}

		public void OnUnionButtonPressed()
		{
		}
	}
}
