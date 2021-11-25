namespace Gluon.Http
{
	public class BuildEventGetEventDataResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public BuildEventUserList build_event_user_data;

			public int is_receivable_event_daily_bonus;

			public BuildEventRewardList[] build_event_reward_list;

			public EventTradeList[] event_trade_list;

			public AtgenEventFortData event_fort_data;
		}

		public CommonResponse data;
	}
}
