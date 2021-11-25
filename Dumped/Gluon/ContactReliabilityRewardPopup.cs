using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class ContactReliabilityRewardPopup : PopupBase
	{
		private class RewardDisplayInfo
		{
			public int level;

			public List<EntityData> rewardItems;

			public bool sentToPresentBoxFlag;
		}

		[SerializeField]
		private Transform iconParent;

		private List<CommonIcon> iconList;

		[SerializeField]
		private Text commentText;

		[SerializeField]
		private GameObject overText;

		private static List<RewardDisplayInfo> sortedRewardList;

		private const int multipleLevelRewardNum = -1;

		public static void RunModelOneByOne(UnityAction onClose, bool isWalker)
		{
		}

		private static void OnSinglePopupDone(UnityAction onModelDone, bool isWalker)
		{
		}

		private static UnitStoryElement GetReriabilityStory(int dragonId)
		{
			return null;
		}

		private static void Create(UnityAction onClose, bool isWalker)
		{
		}

		public void Setup(bool isWalker)
		{
		}

		private CommonIcon CreateIcon(EntityData reward)
		{
			return null;
		}

		protected override void OnDestroy()
		{
		}
	}
}
