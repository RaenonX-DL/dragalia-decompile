namespace Gluon.Http
{
	public class WallGetMonthlyRewardResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenUserWallRewardList[] user_wall_reward_list;
		}

		public CommonResponse data;
	}
}
