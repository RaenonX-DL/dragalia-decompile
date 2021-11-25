namespace Gluon.Http
{
	public class FortBuildAtOnceResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int result;

			public UpdateDataList update_data_list;

			public ulong build_id;

			public FortDetail fort_detail;

			public FortBonusList fort_bonus_list;

			public AtgenProductionRp production_rp;

			public AtgenProductionRp production_df;

			public AtgenProductionRp production_st;
		}

		public CommonResponse data;
	}
}
