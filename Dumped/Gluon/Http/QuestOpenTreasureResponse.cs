namespace Gluon.Http
{
	public class QuestOpenTreasureResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public AtgenBuildEventRewardEntityList[] quest_treasure_reward_list;

			public AtgenDuplicateEntityList[] duplicate_entity_list;

			public int add_max_dragon_quantity;

			public int add_max_weapon_quantity;

			public int add_max_amulet_quantity;
		}

		public CommonResponse data;
	}
}
