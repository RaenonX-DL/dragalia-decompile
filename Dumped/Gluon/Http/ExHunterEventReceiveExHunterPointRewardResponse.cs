namespace Gluon.Http
{
	public class ExHunterEventReceiveExHunterPointRewardResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public BuildEventRewardList[] ex_hunter_event_reward_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
