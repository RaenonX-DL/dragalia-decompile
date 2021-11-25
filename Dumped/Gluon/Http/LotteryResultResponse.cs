namespace Gluon.Http
{
	public class LotteryResultResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenLotteryResultList[] lottery_result_list;
		}

		public CommonResponse data;
	}
}
