using Cute.Http;

namespace Gluon.Http
{
	public class ShopSpecialShopPurchaseRequest : RequestCommon
	{
		public int goods_id;

		public int payment_type;

		public int quantity;

		public AtgenDuplicateEntityList selected_unit;
	}
}
