using Cute.Http;

namespace Gluon.Http
{
	public class QuestSetQuestClearPartyMultiRequest : RequestCommon
	{
		public int quest_id;

		public PartySettingList[] request_party_setting_list;
	}
}
