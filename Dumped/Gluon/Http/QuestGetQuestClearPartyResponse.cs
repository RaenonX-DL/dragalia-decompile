namespace Gluon.Http
{
	public class QuestGetQuestClearPartyResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public PartySettingList[] quest_clear_party_setting_list;

			public AtgenLostUnitList[] lost_unit_list;
		}

		public CommonResponse data;
	}
}
