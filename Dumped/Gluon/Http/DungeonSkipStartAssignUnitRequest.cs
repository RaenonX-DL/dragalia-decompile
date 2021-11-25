using Cute.Http;

namespace Gluon.Http
{
	public class DungeonSkipStartAssignUnitRequest : RequestCommon
	{
		public int quest_id;

		public PartySettingList[] request_party_setting_list;

		public ulong support_viewer_id;

		public int play_count;

		public int bet_count;
	}
}
