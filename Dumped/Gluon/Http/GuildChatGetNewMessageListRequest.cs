using Cute.Http;

namespace Gluon.Http
{
	public class GuildChatGetNewMessageListRequest : RequestCommon
	{
		public int guild_id;

		public ulong chat_message_id;
	}
}
