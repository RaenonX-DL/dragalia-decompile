namespace Gluon.Http
{
	public class GuildUpdateGuildPositionTypeResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public GuildMemberList[] guild_member_list;
		}

		public CommonResponse data;
	}
}
