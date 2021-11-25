namespace Gluon.Http
{
	public class DragonSendGiftMultipleResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public int is_favorite;

			public DragonRewardEntityList[] return_gift_list;

			public RewardReliabilityList[] reward_reliability_list;
		}

		public CommonResponse data;
	}
}
