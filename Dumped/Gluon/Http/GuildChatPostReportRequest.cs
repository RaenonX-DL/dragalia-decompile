using Cute.Http;

namespace Gluon.Http
{
	public class GuildChatPostReportRequest : RequestCommon
	{
		public int guild_id;

		public ulong chat_message_id;

		public int report_category_id;

		public string message;
	}
}
