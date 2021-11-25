namespace Gluon.Http
{
	public class BattleRoyalRecordRoyalRecordMultiResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public BattleRoyalResult battle_royal_result;

			public AtgenBuildEventRewardEntityList[] event_cycle_reward_entity_list;
		}

		public CommonResponse data;
	}
}
