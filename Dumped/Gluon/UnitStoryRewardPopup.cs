using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class UnitStoryRewardPopup : CommonPopup
	{
		public List<AtgenBuildEventRewardEntityList> questStoryActiveRewardList;

		public List<QuestResultModel.FirstClearModel.FirstClearItemInfo> rewardItemList;

		private const float cellSpacing = 20f;

		private const string prefabPath = "Prefabs/OutGame/Fort/UnitStoryList/UnitStoryRewardPopup";

		public static UnitStoryRewardPopup Create([Optional] Transform parentTransform, [Optional] Action OnClosed, bool isCastleReward = false)
		{
			return null;
		}

		public void ReflectParam(QuestRewardTableViewController questRewardTableViewController)
		{
		}
	}
}
