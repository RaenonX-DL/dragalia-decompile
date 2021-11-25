namespace Gluon.Http
{
	public class BuildEventEntryResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public BuildEventUserList build_event_user_data;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public int is_receivable_event_daily_bonus;
		}

		public CommonResponse data;
	}
}
