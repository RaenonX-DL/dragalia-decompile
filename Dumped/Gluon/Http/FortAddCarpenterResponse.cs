namespace Gluon.Http
{
	public class FortAddCarpenterResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int result;

			public UpdateDataList update_data_list;

			public FortDetail fort_detail;
		}

		public CommonResponse data;
	}
}
