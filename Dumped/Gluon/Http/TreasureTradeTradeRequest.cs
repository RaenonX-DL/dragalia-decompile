using Cute.Http;

namespace Gluon.Http
{
	public class TreasureTradeTradeRequest : RequestCommon
	{
		public int trade_group_id;

		public int treasure_trade_id;

		public AtgenNeedUnitList[] need_unit_list;

		public int trade_count;
	}
}
