namespace Gluon.Http
{
	public class QuestSearchQuestClearPartyResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public SearchClearPartyList[] search_quest_clear_party_list;
		}

		public CommonResponse data;
	}
}
