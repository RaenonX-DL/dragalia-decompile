namespace Gluon.Http
{
	public class LotteryLotteryExecResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public AtgenLotteryResultList[] lottery_result_list;
		}

		public CommonResponse data;
	}
}
