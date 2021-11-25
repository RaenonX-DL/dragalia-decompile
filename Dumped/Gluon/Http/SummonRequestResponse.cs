namespace Gluon.Http
{
	public class SummonRequestResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenResultUnitList[] result_unit_list;

			public AtgenResultPrizeList[] result_prize_list;

			public int[] presage_effect_list;

			public int reversal_effect_index;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public SummonTicketList[] summon_ticket_list;

			public int result_summon_point;

			public UserSummonList[] user_summon_list;
		}

		public CommonResponse data;
	}
}
