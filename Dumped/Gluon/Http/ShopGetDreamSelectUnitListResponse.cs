namespace Gluon.Http
{
	public class ShopGetDreamSelectUnitListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenDuplicateEntityList[] dream_select_unit_list;
		}

		public CommonResponse data;
	}
}
