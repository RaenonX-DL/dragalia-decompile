using Cute.Http;

namespace Gluon.Http
{
	public class DebugDungeonStartStartRequest : RequestCommon
	{
		public ulong viewer_id;

		public int quest_id;

		public int play_type;

		public int party_no;

		public int[] party_no_list;

		public int bet_count;

		public int repeat_state;

		public ulong support_viewer_id;

		public RepeatSetting repeat_setting;
	}
}
