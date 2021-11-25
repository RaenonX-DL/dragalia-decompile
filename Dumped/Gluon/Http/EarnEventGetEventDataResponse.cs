namespace Gluon.Http
{
	public class EarnEventGetEventDataResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public EarnEventUserList earn_event_user_data;

			public EventTradeList[] event_trade_list;

			public BuildEventRewardList[] event_reward_list;
		}

		public CommonResponse data;
	}
}
