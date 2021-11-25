namespace Gluon.Http
{
	public class GuildSearchAutoSearchResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public GuildData[] auto_search_guild_list;
		}

		public CommonResponse data;
	}
}
