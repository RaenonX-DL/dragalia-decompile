namespace Gluon.Http
{
	public class DungeonReceiveQuestBonusResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public AtgenReceiveQuestBonus receive_quest_bonus;
		}

		public CommonResponse data;
	}
}
