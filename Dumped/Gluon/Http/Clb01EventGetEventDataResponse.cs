namespace Gluon.Http
{
	public class Clb01EventGetEventDataResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public Clb01EventUserList clb_01_event_user_data;

			public BuildEventRewardList[] clb_01_event_reward_list;

			public CharaFriendshipList[] chara_friendship_list;
		}

		public CommonResponse data;
	}
}
