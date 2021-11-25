namespace Gluon.Http
{
	public class PlatformAchievementGetPlatformAchievementListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AchievementList[] achievement_list;
		}

		public CommonResponse data;
	}
}
