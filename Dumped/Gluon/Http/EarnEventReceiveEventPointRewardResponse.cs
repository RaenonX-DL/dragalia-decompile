namespace Gluon.Http
{
	public class EarnEventReceiveEventPointRewardResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public BuildEventRewardList[] event_reward_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public AtgenBuildEventRewardEntityList[] event_reward_entity_list;
		}

		public CommonResponse data;
	}
}
