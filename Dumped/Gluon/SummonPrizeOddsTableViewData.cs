using Gluon.Http;

namespace Gluon
{
	public class SummonPrizeOddsTableViewData
	{
		public int rank;

		public string rate;

		public GiftType giftType;

		public int id;

		public int quantity;

		public string displayName;

		public bool title;

		public bool caption;

		public SummonPrizeOddsTableViewData()
		{
		}

		public SummonPrizeOddsTableViewData(AtgenSummonPrizeEntitySetList entityInfo, AtgenBuildEventRewardEntityList entityItem)
		{
		}

		public void SetCaption(AtgenSummonPrizeRankList entityInfo)
		{
		}

		public void SetTitle()
		{
		}

		public static string GetRankName(int rank)
		{
			return null;
		}
	}
}
