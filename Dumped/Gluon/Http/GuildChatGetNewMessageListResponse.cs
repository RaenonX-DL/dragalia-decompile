namespace Gluon.Http
{
	public class GuildChatGetNewMessageListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public GuildChatMessageList[] guild_chat_message_list;

			public int polling_interval;
		}

		public CommonResponse data;
	}
}
