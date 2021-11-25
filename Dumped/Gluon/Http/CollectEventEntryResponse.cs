namespace Gluon.Http
{
	public class CollectEventEntryResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public CollectEventUserList collect_event_user_data;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
