namespace Gluon.Http
{
	public class TreasureTradeTradeResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UserTreasureTradeList[] user_treasure_trade_list;

			public TreasureTradeList[] treasure_trade_list;

			public TreasureTradeList[] treasure_trade_all_list;

			public UpdateDataList update_data_list;

			public DeleteDataList delete_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
