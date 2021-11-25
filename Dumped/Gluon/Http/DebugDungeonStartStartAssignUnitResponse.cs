namespace Gluon.Http
{
	public class DebugDungeonStartStartAssignUnitResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public IngameData ingame_data;

			public IngameQuestData ingame_quest_data;

			public OddsInfo odds_info;

			public UpdateDataList update_data_list;
		}

		public CommonResponse data;
	}
}
