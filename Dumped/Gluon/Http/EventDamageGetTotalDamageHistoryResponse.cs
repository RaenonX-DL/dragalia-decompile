namespace Gluon.Http
{
	public class EventDamageGetTotalDamageHistoryResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenEventDamageHistoryList[] event_damage_history_list;
		}

		public CommonResponse data;
	}
}
