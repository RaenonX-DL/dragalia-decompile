namespace Gluon.Http
{
	public class ShopNormalShopPurchaseResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int is_quest_bonus;

			public int is_stone_bonus;

			public int is_stamina_bonus;

			public ShopPurchaseList[] normal_shop_purchase;

			public UpdateDataList update_data_list;
		}

		public CommonResponse data;
	}
}
