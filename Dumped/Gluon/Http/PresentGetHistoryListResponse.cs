namespace Gluon.Http
{
	public class PresentGetHistoryListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public PresentHistoryList[] present_history_list;
		}

		public CommonResponse data;
	}
}
