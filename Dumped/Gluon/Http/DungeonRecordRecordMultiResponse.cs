namespace Gluon.Http
{
	public class DungeonRecordRecordMultiResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public IngameResultData ingame_result_data;

			public TimeAttackRankingData time_attack_ranking_data;

			public EventDamageRanking event_damage_ranking;
		}

		public CommonResponse data;
	}
}
