namespace Gluon.Http
{
	public class FriendIdSearchResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int result;

			public UserSupportList search_user;
		}

		public CommonResponse data;
	}
}
