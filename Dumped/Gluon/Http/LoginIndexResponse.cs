namespace Gluon.Http
{
	public class LoginIndexResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenLoginBonusList[] login_bonus_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public AtgenSupportReward support_reward;

			public int dragon_contact_free_gift_count;

			public AtgenMonthlyWallReceiveList[] monthly_wall_receive_list;

			public AtgenLoginLotteryRewardList[] login_lottery_reward_list;

			public AtgenPenaltyData penalty_data;

			public AtgenExchangeSummomPointList[] exchange_summom_point_list;

			public int before_exchange_summon_item_quantity;

			public int server_time;
		}

		public CommonResponse data;
	}
}
