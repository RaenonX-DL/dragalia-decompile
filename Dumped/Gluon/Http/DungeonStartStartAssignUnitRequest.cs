using Cute.Http;

namespace Gluon.Http
{
	public class DungeonStartStartAssignUnitRequest : RequestCommon
	{
		public int quest_id;

		public PartySettingList[] request_party_setting_list;

		public int bet_count;

		public int repeat_state;

		public ulong support_viewer_id;

		public RepeatSetting repeat_setting;
	}
}
