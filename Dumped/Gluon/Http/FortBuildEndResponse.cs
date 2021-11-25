namespace Gluon.Http
{
	public class FortBuildEndResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int result;

			public ulong build_id;

			public FortBonusList fort_bonus_list;

			public FortDetail fort_detail;

			public AtgenProductionRp production_rp;

			public AtgenProductionRp production_df;

			public AtgenProductionRp production_st;

			public UpdateDataList update_data_list;
		}

		public CommonResponse data;
	}
}
