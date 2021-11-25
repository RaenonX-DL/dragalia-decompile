namespace Gluon.Http
{
	public class DragonBuyGiftToSendResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenShopGiftList[] shop_gift_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public int is_favorite;

			public DragonRewardEntityList[] return_gift_list;

			public RewardReliabilityList[] reward_reliability_list;

			public int dragon_contact_free_gift_count;
		}

		public CommonResponse data;
	}
}
