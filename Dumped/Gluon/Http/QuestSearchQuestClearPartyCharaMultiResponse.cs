namespace Gluon.Http
{
	public class QuestSearchQuestClearPartyCharaMultiResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public SearchClearPartyCharaList[] search_quest_clear_party_chara_list;
		}

		public CommonResponse data;
	}
}
