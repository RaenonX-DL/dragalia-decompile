using Cute.Http;

namespace Gluon.Http
{
	public class ShopNormalShopPurchaseRequest : RequestCommon
	{
		public int goods_id;

		public int payment_type;

		public int quantity;
	}
}
