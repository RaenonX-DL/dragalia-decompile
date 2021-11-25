using Cute.Http;

namespace Gluon.Http
{
	public class GuildJoinReplyRequest : RequestCommon
	{
		public int guild_id;

		public ulong guild_apply_id;

		public int reply_status;
	}
}
