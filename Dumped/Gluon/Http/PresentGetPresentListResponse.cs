namespace Gluon.Http
{
	public class PresentGetPresentListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public PresentDetailList[] present_list;

			public PresentDetailList[] present_limit_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
