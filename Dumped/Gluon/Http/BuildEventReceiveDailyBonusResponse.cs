namespace Gluon.Http
{
	public class BuildEventReceiveDailyBonusResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenBuildEventRewardEntityList[] event_daily_bonus_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
