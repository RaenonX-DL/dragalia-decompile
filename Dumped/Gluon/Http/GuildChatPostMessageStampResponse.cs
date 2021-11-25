namespace Gluon.Http
{
	public class GuildChatPostMessageStampResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public GuildChatMessageList[] guild_chat_message_list;

			public int polling_interval;
		}

		public CommonResponse data;
	}
}
