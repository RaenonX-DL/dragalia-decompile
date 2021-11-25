namespace Gluon.Http
{
	public class FriendAllReplyDenyResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int result;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
