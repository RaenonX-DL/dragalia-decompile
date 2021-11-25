namespace Gluon.Http
{
	public class GuildChatPostMessageTextResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public GuildChatMessageList[] guild_chat_message_list;

			public int polling_interval;
		}

		public CommonResponse data;
	}
}
