namespace Gluon.Http
{
	public class SummonGetSummonHistoryResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public SummonHistoryList[] summon_history_list;
		}

		public CommonResponse data;
	}
}
