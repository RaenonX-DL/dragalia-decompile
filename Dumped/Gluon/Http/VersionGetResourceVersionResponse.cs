namespace Gluon.Http
{
	public class VersionGetResourceVersionResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public string resource_version;
		}

		public CommonResponse data;
	}
}
