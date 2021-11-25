namespace Gluon.Http
{
	public class GuildInviteGetGuildInviteSendDataResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public GuildInviteSendList[] guild_invite_send_list;
		}

		public CommonResponse data;
	}
}
