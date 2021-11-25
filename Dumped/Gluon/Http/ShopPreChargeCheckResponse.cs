namespace Gluon.Http
{
	public class ShopPreChargeCheckResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int is_quest_bonus;

			public int is_stone_bonus;

			public int is_stamina_bonus;

			public ShopPurchaseList[] material_shop_purchase;

			public ShopPurchaseList[] normal_shop_purchase;

			public ShopPurchaseList[] special_shop_purchase;

			public AtgenStoneBonus[] stone_bonus;

			public AtgenStaminaBonus[] stamina_bonus;

			public AtgenQuestBonus[] quest_bonus;

			public AtgenProductLockList[] product_lock_list;

			public ProductList[] product_list;

			public UpdateDataList update_data_list;

			public AtgenUserItemSummon user_item_summon;

			public int infancy_paid_diamond_limit;

			public int is_purchase;
		}

		public CommonResponse data;
	}
}
