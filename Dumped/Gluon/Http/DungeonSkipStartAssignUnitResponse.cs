namespace Gluon.Http
{
	public class DungeonSkipStartAssignUnitResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public IngameResultData ingame_result_data;

			public TimeAttackRankingData time_attack_ranking_data;
		}

		public CommonResponse data;
	}
}
