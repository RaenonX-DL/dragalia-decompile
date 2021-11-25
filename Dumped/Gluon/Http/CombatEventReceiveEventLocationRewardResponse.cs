namespace Gluon.Http
{
	public class CombatEventReceiveEventLocationRewardResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public UserEventLocationRewardList[] user_event_location_reward_list;

			public AtgenBuildEventRewardEntityList[] event_location_reward_entity_list;
		}

		public CommonResponse data;
	}
}
