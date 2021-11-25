namespace Gluon.Http
{
	public class EventTradeGetListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenUserEventTradeList[] user_event_trade_list;

			public EventTradeList[] event_trade_list;

			public MaterialList[] material_list;

			public UserEventItemData user_event_item_data;
		}

		public CommonResponse data;
	}
}
