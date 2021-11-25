namespace Gluon.Http
{
	public class MissionReceiveMainStoryRewardResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public NormalMissionList[] normal_mission_list;

			public DailyMissionList[] daily_mission_list;

			public PeriodMissionList[] period_mission_list;

			public BeginnerMissionList[] beginner_mission_list;

			public SpecialMissionList[] special_mission_list;

			public MainStoryMissionList[] main_story_mission_list;

			public MemoryEventMissionList[] memory_event_mission_list;

			public AlbumMissionList[] album_mission_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public int[] not_received_mission_id_list;

			public int[] need_entry_event_id_list;

			public ConvertedEntityList[] converted_entity_list;
		}

		public CommonResponse data;
	}
}
