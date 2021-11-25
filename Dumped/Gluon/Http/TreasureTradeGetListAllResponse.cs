namespace Gluon.Http
{
	public class TreasureTradeGetListAllResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UserTreasureTradeList[] user_treasure_trade_list;

			public TreasureTradeList[] treasure_trade_list;

			public TreasureTradeList[] treasure_trade_all_list;
		}

		public CommonResponse data;
	}
}
