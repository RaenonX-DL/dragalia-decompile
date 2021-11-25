namespace Gluon.Http
{
	public class WalkerSendGiftMultipleResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public int is_favorite;

			public DragonRewardEntityList[] return_gift_list;

			public RewardReliabilityList[] reward_reliability_list;

			public AtgenWalkerData walker_data;
		}

		public CommonResponse data;
	}
}
