namespace Gluon.Http
{
	public class ItemGetListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public ItemList[] item_list;
		}

		public CommonResponse data;
	}
}
