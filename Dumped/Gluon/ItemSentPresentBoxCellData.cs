using Gluon.Http;

namespace Gluon
{
	public class ItemSentPresentBoxCellData
	{
		public int id;

		public int quantity;

		public GiftType entityType;

		public ItemSentPresentBoxCellData(int id, int quantity, GiftType type)
		{
		}

		public ItemSentPresentBoxCellData(AtgenBuildEventRewardEntityList rewardEntityData)
		{
		}
	}
}
