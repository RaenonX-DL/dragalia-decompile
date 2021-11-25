namespace Gluon.Http
{
	public class GuildInviteInviteReplyAllDenyResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public GuildInviteReceiveList[] guild_invite_receive_list;
		}

		public CommonResponse data;
	}
}
