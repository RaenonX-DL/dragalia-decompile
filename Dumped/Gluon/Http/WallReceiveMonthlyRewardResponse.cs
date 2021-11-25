namespace Gluon.Http
{
	public class WallReceiveMonthlyRewardResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public AtgenBuildEventRewardEntityList[] wall_monthly_reward_list;

			public AtgenUserWallRewardList[] user_wall_reward_list;

			public AtgenMonthlyWallReceiveList[] monthly_wall_receive_list;
		}

		public CommonResponse data;
	}
}
