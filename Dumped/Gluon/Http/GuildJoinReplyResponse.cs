namespace Gluon.Http
{
	public class GuildJoinReplyResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public GuildMemberList[] guild_member_list;

			public GuildApplyList[] guild_apply_list;
		}

		public CommonResponse data;
	}
}
