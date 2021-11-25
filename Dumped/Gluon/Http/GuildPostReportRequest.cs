using Cute.Http;

namespace Gluon.Http
{
	public class GuildPostReportRequest : RequestCommon
	{
		public int guild_id;

		public int report_type;

		public string report_data;

		public int report_category_id;

		public string message;
	}
}
