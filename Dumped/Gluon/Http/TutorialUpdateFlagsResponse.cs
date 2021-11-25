namespace Gluon.Http
{
	public class TutorialUpdateFlagsResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int[] tutorial_flag_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
