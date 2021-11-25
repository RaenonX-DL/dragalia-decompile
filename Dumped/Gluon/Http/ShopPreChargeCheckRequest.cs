using Cute.Http;

namespace Gluon.Http
{
	public class ShopPreChargeCheckRequest : RequestCommon
	{
		public int shop_type;

		public int goods_id;

		public int quantity;
	}
}
