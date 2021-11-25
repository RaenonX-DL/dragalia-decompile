namespace Gluon.Http
{
	public class RedoableSummonFixExecResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UserRedoableSummonData user_redoable_summon_data;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
