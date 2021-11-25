namespace Gluon.Http
{
	public class ShopGetBonusResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int is_quest_bonus;

			public int is_stone_bonus;

			public int is_stamina_bonus;

			public AtgenStoneBonus[] stone_bonus;

			public AtgenStaminaBonus[] stamina_bonus;

			public AtgenQuestBonus[] quest_bonus;

			public AtgenBuildEventRewardEntityList[] stone_bonus_entity_list;

			public UpdateDataList update_data_list;
		}

		public CommonResponse data;
	}
}
