namespace Gluon.Http
{
	public class CombatEventEntryResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public CombatEventUserList combat_event_user_data;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
