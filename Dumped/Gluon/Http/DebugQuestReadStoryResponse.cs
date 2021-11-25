namespace Gluon.Http
{
	public class DebugQuestReadStoryResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public AtgenQuestStoryRewardList[] quest_story_reward_list;
		}

		public CommonResponse data;
	}
}
