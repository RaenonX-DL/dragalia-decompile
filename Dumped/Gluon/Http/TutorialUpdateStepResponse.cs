namespace Gluon.Http
{
	public class TutorialUpdateStepResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int step;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
