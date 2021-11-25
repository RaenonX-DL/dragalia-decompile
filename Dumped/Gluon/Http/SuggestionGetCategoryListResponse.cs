namespace Gluon.Http
{
	public class SuggestionGetCategoryListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenCategoryList[] category_list;
		}

		public CommonResponse data;
	}
}
