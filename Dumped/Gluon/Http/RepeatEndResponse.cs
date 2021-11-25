namespace Gluon.Http
{
	public class RepeatEndResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public IngameResultData ingame_result_data;

			public RepeatData repeat_data;
		}

		public CommonResponse data;
	}
}
