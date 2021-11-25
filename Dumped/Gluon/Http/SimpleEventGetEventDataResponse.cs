namespace Gluon.Http
{
	public class SimpleEventGetEventDataResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public SimpleEventUserList simple_event_user_data;

			public EventTradeList[] event_trade_list;
		}

		public CommonResponse data;
	}
}
