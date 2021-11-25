using Cute.Http;

namespace Gluon.Http
{
	public class ShopMaterialShopPurchaseRequest : RequestCommon
	{
		public int goods_id;

		public int shop_type;

		public int payment_type;

		public int quantity;
	}
}
