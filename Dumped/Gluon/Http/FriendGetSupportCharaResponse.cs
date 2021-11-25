namespace Gluon.Http
{
	public class FriendGetSupportCharaResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int result;

			public SettingSupport setting_support;
		}

		public CommonResponse data;
	}
}
