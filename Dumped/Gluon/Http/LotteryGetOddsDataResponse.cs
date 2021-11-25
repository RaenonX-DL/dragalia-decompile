namespace Gluon.Http
{
	public class LotteryGetOddsDataResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public LotteryOddsRateList lottery_odds_rate_list;
		}

		public CommonResponse data;
	}
}
