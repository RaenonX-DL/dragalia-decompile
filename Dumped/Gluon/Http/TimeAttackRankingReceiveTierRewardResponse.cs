namespace Gluon.Http
{
	public class TimeAttackRankingReceiveTierRewardResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public RankingTierRewardList[] ranking_tier_reward_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public AtgenBuildEventRewardEntityList[] ranking_tier_reward_entity_list;
		}

		public CommonResponse data;
	}
}
