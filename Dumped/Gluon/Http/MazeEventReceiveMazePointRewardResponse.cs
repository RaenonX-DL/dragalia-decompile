namespace Gluon.Http
{
	public class MazeEventReceiveMazePointRewardResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public BuildEventRewardList[] maze_event_reward_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public AtgenBuildEventRewardEntityList[] maze_event_reward_entity_list;
		}

		public CommonResponse data;
	}
}
