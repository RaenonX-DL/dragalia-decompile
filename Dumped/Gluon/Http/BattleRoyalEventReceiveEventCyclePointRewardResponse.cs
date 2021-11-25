namespace Gluon.Http
{
	public class BattleRoyalEventReceiveEventCyclePointRewardResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public EventCycleRewardList[] event_cycle_reward_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public AtgenBuildEventRewardEntityList[] event_cycle_reward_entity_list;
		}

		public CommonResponse data;
	}
}
