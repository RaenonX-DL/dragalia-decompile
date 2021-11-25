namespace Gluon.Http
{
	public class AbilityCrestTradeGetListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UserAbilityCrestTradeList[] user_ability_crest_trade_list;

			public AbilityCrestTradeList[] ability_crest_trade_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
