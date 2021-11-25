namespace Gluon.Http
{
	public class DungeonFailResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int result;

			public UserSupportList[] fail_helper_list;

			public AtgenHelperDetailList[] fail_helper_detail_list;

			public AtgenFailQuestDetail fail_quest_detail;
		}

		public CommonResponse data;
	}
}
