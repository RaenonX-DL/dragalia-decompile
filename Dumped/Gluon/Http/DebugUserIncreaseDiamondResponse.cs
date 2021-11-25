namespace Gluon.Http
{
	public class DebugUserIncreaseDiamondResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int paid_diamond;

			public int free_diamond;
		}

		public CommonResponse data;
	}
}
