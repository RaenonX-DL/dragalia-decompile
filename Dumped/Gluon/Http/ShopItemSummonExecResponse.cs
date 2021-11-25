namespace Gluon.Http
{
	public class ShopItemSummonExecResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenUserItemSummon user_item_summon;

			public AtgenBuildEventRewardEntityList[] item_summon_reward_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
