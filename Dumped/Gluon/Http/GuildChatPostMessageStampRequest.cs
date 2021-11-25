using Cute.Http;

namespace Gluon.Http
{
	public class GuildChatPostMessageStampRequest : RequestCommon
	{
		public int guild_id;

		public ulong chat_message_id;

		public int chat_message_stamp_id;
	}
}
