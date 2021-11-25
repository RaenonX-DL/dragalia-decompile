namespace Gluon.Http
{
	public class FortLevelupCancelResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int result;

			public ulong build_id;

			public FortDetail fort_detail;

			public UpdateDataList update_data_list;
		}

		public CommonResponse data;
	}
}
