namespace Gluon.Http
{
	public class ToolSignupResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public ulong viewer_id;

			public int servertime;
		}

		public CommonResponse data;
	}
}
