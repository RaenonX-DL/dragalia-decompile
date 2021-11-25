namespace Gluon.Http
{
	public class UpdateNamechangeResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public string checked_name;
		}

		public CommonResponse data;
	}
}
