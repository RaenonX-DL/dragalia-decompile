namespace Gluon.Http
{
	public class FortBuildStartResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int result;

			public ulong build_id;

			public int build_start_date;

			public int build_end_date;

			public int remain_time;

			public FortDetail fort_detail;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
