namespace Gluon.Http
{
	public class FriendFriendListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int result;

			public UserSupportList[] friend_list;

			public ulong[] new_friend_viewer_id_list;
		}

		public CommonResponse data;
	}
}
