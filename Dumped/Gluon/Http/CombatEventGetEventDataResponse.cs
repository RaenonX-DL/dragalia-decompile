namespace Gluon.Http
{
	public class CombatEventGetEventDataResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public CombatEventUserList combat_event_user_data;

			public EventTradeList[] event_trade_list;

			public BuildEventRewardList[] event_reward_list;

			public UserEventLocationRewardList[] user_event_location_reward_list;
		}

		public CommonResponse data;
	}
}
