namespace Gluon.Http
{
	public class EventSummonExecResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenBoxSummonResult box_summon_result;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
