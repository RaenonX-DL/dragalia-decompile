namespace Gluon.Http
{
	public class CartoonLatestResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenLatest latest;
		}

		public CommonResponse data;
	}
}
