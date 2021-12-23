namespace Gluon.Http
{
	public class DmodeBuildupServitorPassiveResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public DmodeServitorPassiveList[] dmode_servitor_passive_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
