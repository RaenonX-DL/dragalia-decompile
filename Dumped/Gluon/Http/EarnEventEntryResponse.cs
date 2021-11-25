namespace Gluon.Http
{
	public class EarnEventEntryResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public EarnEventUserList earn_event_user_data;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
