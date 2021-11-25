namespace Gluon.Http
{
	public class SummonGetSummonPointTradeResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenSummonPointTradeList[] summon_point_trade_list;

			public SummonPointList[] summon_point_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
