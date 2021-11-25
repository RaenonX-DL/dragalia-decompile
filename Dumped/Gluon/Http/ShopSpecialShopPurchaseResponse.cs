namespace Gluon.Http
{
	public class ShopSpecialShopPurchaseResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int is_quest_bonus;

			public int is_stone_bonus;

			public int is_stamina_bonus;

			public ShopPurchaseList[] special_shop_purchase;

			public AtgenStoneBonus[] stone_bonus;

			public AtgenStaminaBonus[] stamina_bonus;

			public AtgenQuestBonus[] quest_bonus;

			public UpdateDataList update_data_list;
		}

		public CommonResponse data;
	}
}
