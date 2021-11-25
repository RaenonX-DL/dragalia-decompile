namespace Gluon.Http
{
	public class GuildInviteGetGuildInviteReceiveDataResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public GuildInviteReceiveList[] guild_invite_receive_list;
		}

		public CommonResponse data;
	}
}
