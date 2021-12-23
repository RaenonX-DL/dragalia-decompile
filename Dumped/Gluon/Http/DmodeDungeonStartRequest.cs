using Cute.Http;

namespace Gluon.Http
{
	public class DmodeDungeonStartRequest : RequestCommon
	{
		public int chara_id;

		public int start_floor_num;

		public int servitor_id;

		public int[] bring_edit_skill_chara_id_list;
	}
}
