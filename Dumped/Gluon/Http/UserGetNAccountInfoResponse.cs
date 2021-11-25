namespace Gluon.Http
{
	public class UserGetNAccountInfoResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public AtgenNAccountInfo n_account_info;
		}

		public CommonResponse data;
	}
}
