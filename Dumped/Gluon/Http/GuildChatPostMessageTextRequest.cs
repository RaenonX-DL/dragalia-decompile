using Cute.Http;

namespace Gluon.Http
{
	public class GuildChatPostMessageTextRequest : RequestCommon
	{
		public int guild_id;

		public ulong chat_message_id;

		public string chat_message_text;
	}
}
