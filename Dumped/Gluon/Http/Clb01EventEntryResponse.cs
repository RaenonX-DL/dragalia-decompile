namespace Gluon.Http
{
	public class Clb01EventEntryResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public Clb01EventUserList clb_01_event_user_data;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
