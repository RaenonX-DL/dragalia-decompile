using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class QuestStoryClearReward : MonoBehaviour
	{
		private Action OnEnded;

		private bool hasItemReward;

		private bool hasFacilityReward;

		private int facilityPlantId;

		private bool isEvent;

		private Transform parentTransform;

		public FlashPlayerManager flashMgr;

		public Action<int, GiftType, int, Action> onNewEnrollmentPopup;

		public bool isEventEnable => default(bool);

		private void Start()
		{
		}

		public void CheckStoryReward(bool isEvent, [Optional] Transform parentTransform, [Optional] Action OnEnded, bool isFirstTime = false)
		{
		}

		private void ShowNextCharaDragonRewardPopup(int startIndex)
		{
		}

		public void CharaDragonPopupCreate(QuestResultModel.FirstClearModel.FirstClearItemInfo info, int startIndex)
		{
		}

		private void ShowItemRewardPopup()
		{
		}

		private void ShowFacilityRewardPopup()
		{
		}

		private void CheckDuplicateItem()
		{
		}

		private void OnBeforeLeaving(bool clearStoryRewardList = true)
		{
		}

		private PopupBase CheckStoryRewardDuplicate(int id, GiftType type)
		{
			return null;
		}

		private PopupBase CheckStoryRewardListDuplicateList()
		{
			return null;
		}

		private void CheckRaidChara()
		{
		}

		private bool IsExistCharaInQuestStoryReward()
		{
			return default(bool);
		}
	}
}
