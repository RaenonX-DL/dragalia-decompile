namespace Gluon.Http
{
	public class SummonSummonPointTradeResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenBuildEventRewardEntityList[] exchange_entity_list;

			public UpdateDataList update_data_list;
		}

		public CommonResponse data;
	}
}
