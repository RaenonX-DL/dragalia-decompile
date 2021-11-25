namespace Gluon.Http
{
	public class CastleStoryReadResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenBuildEventRewardEntityList[] castle_story_reward_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public AtgenDuplicateEntityList[] duplicate_entity_list;
		}

		public CommonResponse data;
	}
}
