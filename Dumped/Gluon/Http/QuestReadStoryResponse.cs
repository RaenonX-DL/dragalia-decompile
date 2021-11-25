namespace Gluon.Http
{
	public class QuestReadStoryResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public AtgenQuestStoryRewardList[] quest_story_reward_list;

			public ConvertedEntityList[] converted_entity_list;
		}

		public CommonResponse data;
	}
}
