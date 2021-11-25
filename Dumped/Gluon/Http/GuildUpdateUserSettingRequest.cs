using Cute.Http;

namespace Gluon.Http
{
	public class GuildUpdateUserSettingRequest : RequestCommon
	{
		public int profile_entity_type;

		public int profile_entity_id;

		public int profile_entity_rarity;

		public int guild_push_notification_type_running;

		public int guild_push_notification_type_suspending;

		public int is_enable_invite_receive;
	}
}
