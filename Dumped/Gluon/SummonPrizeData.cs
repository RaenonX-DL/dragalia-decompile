using Gluon.Http;

namespace Gluon
{
	public class SummonPrizeData
	{
		public GiftType entityType;

		public int entityId;

		public int entityQuantity;

		public void UpdateDataFromResponse(AtgenBuildEventRewardEntityList data)
		{
		}

		public SummonPrizeData Clone()
		{
			return null;
		}
	}
}
