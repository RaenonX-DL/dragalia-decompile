namespace Gluon.Http
{
	public class FortLevelupEndResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int result;

			public ulong build_id;

			public FortDetail fort_detail;

			public FortBonusList fort_bonus_list;

			public int current_fort_level;

			public int current_fort_craft_level;

			public AtgenProductionRp production_rp;

			public AtgenProductionRp production_df;

			public AtgenProductionRp production_st;

			public UpdateDataList update_data_list;
		}

		public CommonResponse data;
	}
}
