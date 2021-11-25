using Cute.Http;

namespace Gluon.Http
{
	public class GuildEstablishRequest : RequestCommon
	{
		public string guild_name;

		public int guild_emblem_id;

		public int joining_condition_type;

		public int activity_policy_type;

		public string guild_introduction;

		public string guild_board;
	}
}
