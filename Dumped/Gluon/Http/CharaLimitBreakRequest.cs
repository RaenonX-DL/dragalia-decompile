using Cute.Http;

namespace Gluon.Http
{
	public class CharaLimitBreakRequest : RequestCommon
	{
		public int chara_id;

		public int next_limit_break_count;

		public int is_use_grow_material;
	}
}
