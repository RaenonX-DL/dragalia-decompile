namespace Gluon.Http
{
	public class FortMoveResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int result;

			public ulong build_id;

			public FortBonusList fort_bonus_list;

			public AtgenProductionRp production_rp;

			public AtgenProductionRp production_df;

			public AtgenProductionRp production_st;

			public UpdateDataList update_data_list;
		}

		public CommonResponse data;
	}
}
