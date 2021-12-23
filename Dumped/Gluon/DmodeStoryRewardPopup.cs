using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class DmodeStoryRewardPopup : CommonPopup
	{
		public List<AtgenBuildEventRewardEntityList> questStoryActiveRewardList;

		public List<QuestResultModel.FirstClearModel.FirstClearItemInfo> rewardItemList;

		private const string prefabPath = "Prefabs/OutGame/Dmode/DmodeStory/DmodeStoryRewardPopup";

		public static DmodeStoryRewardPopup Create([Optional] Transform parentTransform, [Optional] Action OnClosed)
		{
			return null;
		}

		public void ReflectParam(QuestRewardTableViewController questRewardTableViewController)
		{
		}
	}
}
