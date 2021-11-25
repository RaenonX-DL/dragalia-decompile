namespace Gluon.Http
{
	public class FortGetDataResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public FortDetail fort_detail;

			public BuildList[] build_list;

			public FortBonusList fort_bonus_list;

			public AtgenProductionRp production_rp;

			public AtgenProductionRp production_df;

			public AtgenProductionRp production_st;

			public int dragon_contact_free_gift_count;

			public int current_server_time;
		}

		public CommonResponse data;
	}
}
