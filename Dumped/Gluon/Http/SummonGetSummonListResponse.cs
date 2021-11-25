namespace Gluon.Http
{
	public class SummonGetSummonListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public SummonList[] summon_list;

			public SummonList[] chara_ssr_summon_list;

			public SummonList[] dragon_ssr_summon_list;

			public SummonList[] chara_ssr_update_summon_list;

			public SummonList[] dragon_ssr_update_summon_list;

			public SummonList[] campaign_summon_list;

			public SummonList[] campaign_ssr_summon_list;

			public SummonList[] platinum_summon_list;

			public SummonList[] exclude_summon_list;

			public AtgenCsSummonList cs_summon_list;

			public SummonTicketList[] summon_ticket_list;

			public SummonPointList[] summon_point_list;
		}

		public CommonResponse data;
	}
}
