namespace Gluon.Http
{
	public class RaidEventEntryResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public RaidEventUserList raid_event_user_data;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
