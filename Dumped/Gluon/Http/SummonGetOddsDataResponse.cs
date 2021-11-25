namespace Gluon.Http
{
	public class SummonGetOddsDataResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public OddsRateList odds_rate_list;

			public SummonPrizeOddsRateList summon_prize_odds_rate_list;
		}

		public CommonResponse data;
	}
}
