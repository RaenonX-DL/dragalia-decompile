namespace Gluon.Http
{
	public class DmodeExpeditionForceFinishResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public DmodeIngameResult dmode_ingame_result;

			public DmodeExpedition dmode_expedition;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
