namespace Gluon.Http
{
	public class GuildSearchIdSearchResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public GuildData[] search_guild_list;
		}

		public CommonResponse data;
	}
}
