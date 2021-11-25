namespace Gluon.Http
{
	public class ExchangeGetUnitListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenDuplicateEntityList[] select_unit_list;
		}

		public CommonResponse data;
	}
}
