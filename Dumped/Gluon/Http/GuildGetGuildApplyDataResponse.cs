namespace Gluon.Http
{
	public class GuildGetGuildApplyDataResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public GuildApplyList[] guild_apply_list;
		}

		public CommonResponse data;
	}
}
