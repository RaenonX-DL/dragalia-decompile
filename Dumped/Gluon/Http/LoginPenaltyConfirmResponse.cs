namespace Gluon.Http
{
	public class LoginPenaltyConfirmResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int result;

			public AtgenPenaltyData penalty_data;
		}

		public CommonResponse data;
	}
}
