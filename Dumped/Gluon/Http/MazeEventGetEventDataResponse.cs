namespace Gluon.Http
{
	public class MazeEventGetEventDataResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public MazeEventUserList maze_event_user_data;

			public BuildEventRewardList[] maze_event_reward_list;

			public EventTradeList[] event_trade_list;
		}

		public CommonResponse data;
	}
}
