namespace Gluon.Http
{
	public class GuildJoinRequestCancelResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;
		}

		public CommonResponse data;
	}
}