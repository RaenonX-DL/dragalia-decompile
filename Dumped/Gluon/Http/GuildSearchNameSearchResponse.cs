namespace Gluon.Http
{
	public class GuildSearchNameSearchResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public GuildData[] search_guild_list;
		}

		public CommonResponse data;
	}
}
