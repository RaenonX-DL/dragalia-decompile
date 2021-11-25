using Cute.Http;

namespace Gluon.Http
{
	public class GuildChatGetOldMessageListRequest : RequestCommon
	{
		public int guild_id;

		public ulong chat_message_id;
	}
}
