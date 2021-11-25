namespace Gluon.Http
{
	public class GuildJoinResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public GuildMemberList[] guild_member_list;
		}

		public CommonResponse data;
	}
}
