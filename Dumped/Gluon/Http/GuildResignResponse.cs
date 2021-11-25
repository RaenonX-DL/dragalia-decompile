namespace Gluon.Http
{
	public class GuildResignResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;
		}

		public CommonResponse data;
	}
}
