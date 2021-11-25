namespace Gluon.Http
{
	public class QuestSearchQuestClearPartyMultiResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public SearchClearPartyList[] search_quest_clear_party_list;
		}

		public CommonResponse data;
	}
}
