using Cute.Http;

namespace Gluon.Http
{
	public class DragonLimitBreakRequest : RequestCommon
	{
		public ulong base_dragon_key_id;

		public LimitBreakGrowList[] limit_break_grow_list;
	}
}
