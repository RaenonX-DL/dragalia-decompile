namespace Gluon.Http
{
	public class DmodeExpeditionStartResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public DmodeExpedition dmode_expedition;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
