namespace Gluon.Http
{
	public class ShopMaterialShopPurchaseResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int is_quest_bonus;

			public int is_stone_bonus;

			public int is_stamina_bonus;

			public ShopPurchaseList[] material_shop_purchase;

			public UpdateDataList update_data_list;
		}

		public CommonResponse data;
	}
}
