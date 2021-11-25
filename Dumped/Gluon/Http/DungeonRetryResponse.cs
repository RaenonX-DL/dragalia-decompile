namespace Gluon.Http
{
	public class DungeonRetryResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int continue_count;

			public UpdateDataList update_data_list;
		}

		public CommonResponse data;
	}
}
