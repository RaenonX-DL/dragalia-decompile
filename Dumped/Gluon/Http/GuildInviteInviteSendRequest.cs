using Cute.Http;

namespace Gluon.Http
{
	public class GuildInviteInviteSendRequest : RequestCommon
	{
		public ulong target_viewer_id;

		public int guild_id;

		public int guild_invite_message_id;
	}
}
