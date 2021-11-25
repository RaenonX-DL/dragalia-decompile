namespace Gluon.Http
{
	public class DragonGetContactDataResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenShopGiftList[] shop_gift_list;
		}

		public CommonResponse data;
	}
}
