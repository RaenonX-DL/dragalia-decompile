namespace Gluon.Http
{
	public class ShopItemSummonOddResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenItemSummonRateList[] item_summon_rate_list;
		}

		public CommonResponse data;
	}
}
