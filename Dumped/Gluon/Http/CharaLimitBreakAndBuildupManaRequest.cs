using Cute.Http;

namespace Gluon.Http
{
	public class CharaLimitBreakAndBuildupManaRequest : RequestCommon
	{
		public int chara_id;

		public int next_limit_break_count;

		public int[] mana_circle_piece_id_list;

		public int is_use_grow_material;
	}
}
