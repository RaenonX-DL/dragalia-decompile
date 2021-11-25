namespace Gluon.Http
{
	public class StampGetStampResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public StampList[] stamp_list;
		}

		public CommonResponse data;
	}
}
