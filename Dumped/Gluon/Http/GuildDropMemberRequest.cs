using Cute.Http;

namespace Gluon.Http
{
	public class GuildDropMemberRequest : RequestCommon
	{
		public int guild_id;

		public ulong target_viewer_id;
	}
}
