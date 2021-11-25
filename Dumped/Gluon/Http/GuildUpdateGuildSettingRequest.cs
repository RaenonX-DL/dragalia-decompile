using Cute.Http;

namespace Gluon.Http
{
	public class GuildUpdateGuildSettingRequest : RequestCommon
	{
		public int guild_id;

		public string guild_name;

		public int guild_emblem_id;

		public string guild_introduction;

		public string guild_board;

		public int joining_condition_type;

		public int activity_policy_type;
	}
}
