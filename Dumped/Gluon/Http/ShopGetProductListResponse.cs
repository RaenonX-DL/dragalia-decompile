namespace Gluon.Http
{
	public class ShopGetProductListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public ProductList[] product_list;

			public UpdateDataList update_data_list;

			public int infancy_paid_diamond_limit;
		}

		public CommonResponse data;
	}
}
