using Gluon.Master;

namespace Gluon
{
	public class EventRewardCellData
	{
		public int rewardId;

		public int eventItemId;

		public int eventItemQuantity;

		public GiftType rewardEntityType;

		public int rewardEntityId;

		public int rewardEntityQuantity;

		public bool isShowBadge;

		public bool hasGot;

		public int eventId;

		public int cycleId;

		public int cyclePoint;

		public EventRewardCellData(RaidEventRewardElement eventReward)
		{
		}

		public EventRewardCellData(MazeEventRewardElement eventReward)
		{
		}

		public EventRewardCellData(BuildEventRewardElement eventReward)
		{
		}

		public EventRewardCellData(EventCyclePointRewardElement eventReward, int eventId, int cycleId, int cyclePoint)
		{
		}

		public EventRewardCellData(EventDamageRewardElement eventReward)
		{
		}
	}
}
