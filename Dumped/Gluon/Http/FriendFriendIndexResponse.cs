namespace Gluon.Http
{
	public class FriendFriendIndexResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public int friend_count;
		}

		public CommonResponse data;
	}
}
