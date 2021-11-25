namespace Gluon.Http
{
	public class RaidEventGetEventDataResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public RaidEventUserList raid_event_user_data;

			public RaidEventRewardList[] raid_event_reward_list;

			public CharaFriendshipList[] chara_friendship_list;

			public EventTradeList[] event_trade_list;

			public EventPassiveList[] event_passive_list;

			public EventAbilityCharaList[] event_ability_chara_list;

			public int is_receive_event_damage_reward;

			public AtgenEventDamageData event_damage_data;
		}

		public CommonResponse data;
	}
}
