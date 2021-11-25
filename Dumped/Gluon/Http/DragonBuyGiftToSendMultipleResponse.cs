namespace Gluon.Http
{
	public class DragonBuyGiftToSendMultipleResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenShopGiftList[] shop_gift_list;

			public AtgenDragonGiftRewardList[] dragon_gift_reward_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public int dragon_contact_free_gift_count;
		}

		public CommonResponse data;
	}
}
