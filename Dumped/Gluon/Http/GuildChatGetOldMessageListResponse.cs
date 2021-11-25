namespace Gluon.Http
{
	public class GuildChatGetOldMessageListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public GuildChatMessageList[] guild_chat_message_list;
		}

		public CommonResponse data;
	}
}
