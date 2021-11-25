namespace Gluon.Http
{
	public class FriendRequestListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int result;

			public UserSupportList[] request_list;
		}

		public CommonResponse data;
	}
}
