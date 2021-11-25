namespace Gluon.Http
{
	public class FriendApplyListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int result;

			public UserSupportList[] friend_apply;

			public ulong[] new_apply_viewer_id_list;
		}

		public CommonResponse data;
	}
}
