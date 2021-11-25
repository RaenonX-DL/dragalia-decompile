namespace Gluon.Http
{
	public class GuildGetGuildMemberDataResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public GuildMemberList[] guild_member_list;
		}

		public CommonResponse data;
	}
}
