using Gluon.Master;

namespace Gluon
{
	public class QuestEventRewardCellData
	{
		public int rewardId;

		public int eventItemId;

		public int eventItemQuantity;

		public GiftType rewardEntityType;

		public int rewardEntityId;

		public int rewardEntityQuantity;

		public int tier;

		public int rewardGetClearTime;

		public string rankingRewardDetailText;

		public string questNameStr;

		public QuestEventType questEventType;

		public bool isShowBadge;

		public bool hasGot;

		public QuestEventRewardCellData(RankingTierRewardElement eventReward)
		{
		}
	}
}
