namespace Gluon.Http
{
	public class MissionReceiveDrillRewardResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public DrillMissionList[] drill_mission_list;

			public DrillMissionGroupList[] drill_mission_group_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public int[] not_received_mission_id_list;

			public int[] need_entry_event_id_list;

			public ConvertedEntityList[] converted_entity_list;

			public AtgenBuildEventRewardEntityList[] drill_mission_group_complete_reward_list;
		}

		public CommonResponse data;
	}
}
