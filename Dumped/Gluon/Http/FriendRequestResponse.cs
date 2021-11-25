namespace Gluon.Http
{
	public class FriendRequestResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int result;

			public UpdateDataList update_data_list;
		}

		public CommonResponse data;
	}
}
