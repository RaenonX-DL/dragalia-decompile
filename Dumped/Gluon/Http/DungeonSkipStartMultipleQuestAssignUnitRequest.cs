using Cute.Http;

namespace Gluon.Http
{
	public class DungeonSkipStartMultipleQuestAssignUnitRequest : RequestCommon
	{
		public PartySettingList[] request_party_setting_list;

		public AtgenRequestQuestMultipleList[] request_quest_multiple_list;

		public ulong support_viewer_id;
	}
}
