namespace Gluon.Http
{
	public class AmuletTradeGetListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UserAmuletTradeList[] user_amulet_trade_list;

			public AmuletTradeList[] amulet_trade_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
