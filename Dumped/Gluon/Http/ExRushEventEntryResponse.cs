namespace Gluon.Http
{
	public class ExRushEventEntryResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public ExRushEventUserList ex_rush_event_user_data;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
