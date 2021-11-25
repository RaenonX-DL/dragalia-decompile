using Cute.Http;

namespace Gluon.Http
{
	public class GuildInviteInviteCancelRequest : RequestCommon
	{
		public int guild_id;

		public ulong guild_invite_id;
	}
}
