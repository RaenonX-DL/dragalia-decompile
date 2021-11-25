namespace Gluon.Http
{
	public class FortLevelupStartResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int result;

			public int levelup_start_date;

			public int levelup_end_date;

			public int remain_time;

			public ulong build_id;

			public FortDetail fort_detail;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
