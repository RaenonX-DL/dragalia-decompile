namespace Gluon.Http
{
	public class DebugCommonGetGeohashResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public string geohash;
		}

		public CommonResponse data;
	}
}
