namespace Gluon.Http
{
	public class QuestGetQuestClearPartyMultiResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public PartySettingList[] quest_multi_clear_party_setting_list;

			public AtgenLostUnitList[] lost_unit_list;
		}

		public CommonResponse data;
	}
}
