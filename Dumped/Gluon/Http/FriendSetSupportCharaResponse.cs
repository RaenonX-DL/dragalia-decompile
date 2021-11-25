namespace Gluon.Http
{
	public class FriendSetSupportCharaResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int result;

			public UpdateDataList update_data_list;

			public SettingSupport setting_support;
		}

		public CommonResponse data;
	}
}
