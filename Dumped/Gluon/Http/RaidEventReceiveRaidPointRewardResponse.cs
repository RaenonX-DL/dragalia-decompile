namespace Gluon.Http
{
	public class RaidEventReceiveRaidPointRewardResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public RaidEventRewardList[] raid_event_reward_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
