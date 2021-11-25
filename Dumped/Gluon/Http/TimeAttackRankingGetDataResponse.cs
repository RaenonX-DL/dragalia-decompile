namespace Gluon.Http
{
	public class TimeAttackRankingGetDataResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public RankingTierRewardList[] ranking_tier_reward_list;
		}

		public CommonResponse data;
	}
}
