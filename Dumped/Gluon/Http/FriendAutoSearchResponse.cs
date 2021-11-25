namespace Gluon.Http
{
	public class FriendAutoSearchResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int result;

			public UserSupportList[] search_list;
		}

		public CommonResponse data;
	}
}
