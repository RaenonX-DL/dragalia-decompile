using Cute.Http;

namespace Gluon.Http
{
	public class GuildInviteInviteReplyRequest : RequestCommon
	{
		public int guild_id;

		public ulong guild_invite_id;

		public int reply_status;
	}
}
