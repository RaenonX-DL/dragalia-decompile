namespace Gluon.Http
{
	public class GuildDisbandResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;
		}

		public CommonResponse data;
	}
}
