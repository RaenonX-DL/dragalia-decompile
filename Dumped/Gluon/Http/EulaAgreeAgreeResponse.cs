namespace Gluon.Http
{
	public class EulaAgreeAgreeResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenVersionHash version_hash;

			public int is_optin;
		}

		public CommonResponse data;
	}
}
