namespace Gluon.Http
{
	public class EventTradeTradeResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenUserEventTradeList[] user_event_trade_list;

			public EventTradeList[] event_trade_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public MaterialList[] material_list;

			public UserEventItemData user_event_item_data;
		}

		public CommonResponse data;
	}
}
