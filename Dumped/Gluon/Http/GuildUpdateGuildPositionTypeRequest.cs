using Cute.Http;

namespace Gluon.Http
{
	public class GuildUpdateGuildPositionTypeRequest : RequestCommon
	{
		public int guild_id;

		public ulong target_viewer_id;

		public int guild_position_type;
	}
}
