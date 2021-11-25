namespace Gluon.Http
{
	public class FortSetNewFortPlantResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int result;

			public UpdateDataList update_data_list;
		}

		public CommonResponse data;
	}
}
