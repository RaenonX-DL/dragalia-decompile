namespace Gluon.Http
{
	public class EventStoryReadResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenBuildEventRewardEntityList[] event_story_reward_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
