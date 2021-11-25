namespace Gluon.Http
{
	public class Clb01EventReceiveClb01PointRewardResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public BuildEventRewardList[] clb_01_event_reward_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public AtgenBuildEventRewardEntityList[] clb_01_event_reward_entity_list;
		}

		public CommonResponse data;
	}
}
