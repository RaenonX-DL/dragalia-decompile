namespace Gluon.Http
{
	public class SimpleEventEntryResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public SimpleEventUserList simple_event_user_data;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
