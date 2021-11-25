using Cute.Http;

namespace Gluon.Http
{
	public class DungeonStartStartMultiAssignUnitRequest : RequestCommon
	{
		public int quest_id;

		public PartySettingList[] request_party_setting_list;
	}
}
