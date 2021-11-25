namespace Gluon.Http
{
	public class QuestGetSupportUserListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UserSupportList[] support_user_list;

			public AtgenSupportUserDetailList[] support_user_detail_list;
		}

		public CommonResponse data;
	}
}
