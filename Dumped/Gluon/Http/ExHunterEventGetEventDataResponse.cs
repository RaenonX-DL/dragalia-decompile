namespace Gluon.Http
{
	public class ExHunterEventGetEventDataResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public ExHunterEventUserList ex_hunter_event_user_data;

			public BuildEventRewardList[] ex_hunter_event_reward_list;

			public EventTradeList[] event_trade_list;

			public EventPassiveList[] event_passive_list;
		}

		public CommonResponse data;
	}
}
