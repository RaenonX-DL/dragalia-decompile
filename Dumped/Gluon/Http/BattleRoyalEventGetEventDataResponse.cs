namespace Gluon.Http
{
	public class BattleRoyalEventGetEventDataResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public BattleRoyalEventUserRecord battle_royal_event_user_record;

			public BattleRoyalCycleUserRecord battle_royal_cycle_user_record;

			public BattleRoyalEventItemList[] battle_royal_event_item_list;

			public EventCycleRewardList[] event_cycle_reward_list;

			public BattleRoyalCharaSkinList[] battle_royal_chara_skin_list;

			public EventTradeList[] event_trade_list;
		}

		public CommonResponse data;
	}
}
