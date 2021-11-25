using Cute.Http;

namespace Gluon.Http
{
	public class DungeonStartStartRequest : RequestCommon
	{
		public int quest_id;

		public int party_no;

		public int[] party_no_list;

		public int bet_count;

		public int repeat_state;

		public ulong support_viewer_id;

		public RepeatSetting repeat_setting;
	}
}
