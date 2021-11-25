using Cute.Http;

namespace Gluon.Http
{
	public class GuildJoinReplyAllDenyRequest : RequestCommon
	{
		public int guild_id;

		public ulong[] guild_apply_id_list;
	}
}
