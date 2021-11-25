namespace Gluon.Http
{
	public class ExRushEventGetEventDataResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public ExRushEventUserList ex_rush_event_user_data;

			public CharaFriendshipList[] chara_friendship_list;

			public EventTradeList[] event_trade_list;
		}

		public CommonResponse data;
	}
}
