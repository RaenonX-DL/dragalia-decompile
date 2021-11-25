using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class QuestStoryRewardPopup : CommonPopup
	{
		public List<AtgenQuestStoryRewardList> questStoryActiveRewardList;

		public List<QuestResultModel.FirstClearModel.FirstClearItemInfo> rewardItemList;

		private const float cellSpacing = 20f;

		private const float cellCenterPositionY = -160f;

		public static QuestStoryRewardPopup Create([Optional] Transform parentTransform, [Optional] Action OnClosed)
		{
			return null;
		}

		public void ReflectParam(QuestRewardTableViewController questRewardTableViewController)
		{
		}

		public List<AtgenQuestStoryRewardList> GetStoryRewardList()
		{
			return null;
		}
	}
}
