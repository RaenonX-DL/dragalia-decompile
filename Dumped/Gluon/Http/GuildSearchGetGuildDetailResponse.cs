namespace Gluon.Http
{
	public class GuildSearchGetGuildDetailResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public GuildData[] search_guild_list;
		}

		public CommonResponse data;
	}
}
