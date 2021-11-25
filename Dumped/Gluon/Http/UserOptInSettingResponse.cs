namespace Gluon.Http
{
	public class UserOptInSettingResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int is_optin;
		}

		public CommonResponse data;
	}
}
