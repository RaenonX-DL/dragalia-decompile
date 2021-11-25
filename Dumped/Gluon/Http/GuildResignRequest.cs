using Cute.Http;

namespace Gluon.Http
{
	public class GuildResignRequest : RequestCommon
	{
		public int guild_id;

		public int is_temporary_member;
	}
}
