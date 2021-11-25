using Cute.Http;

namespace Gluon.Http
{
	public class DebugDungeonStartStartAssignUnitRequest : RequestCommon
	{
		public ulong viewer_id;

		public int quest_id;

		public int play_type;

		public PartySettingList[] request_party_setting_list;

		public int bet_count;

		public int repeat_state;

		public ulong support_viewer_id;

		public RepeatSetting repeat_setting;
	}
}
