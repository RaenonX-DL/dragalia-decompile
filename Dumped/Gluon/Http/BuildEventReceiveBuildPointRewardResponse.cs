namespace Gluon.Http
{
	public class BuildEventReceiveBuildPointRewardResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public BuildEventRewardList[] build_event_reward_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public AtgenBuildEventRewardEntityList[] build_event_reward_entity_list;
		}

		public CommonResponse data;
	}
}
