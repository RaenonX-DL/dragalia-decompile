namespace Gluon.Http
{
	public class QuestDropListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenQuestDropInfo quest_drop_info;
		}

		public CommonResponse data;
	}
}
