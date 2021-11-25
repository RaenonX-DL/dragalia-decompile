namespace Gluon.Http
{
	public class MissionGetMissionListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public NormalMissionList[] normal_mission_list;

			public DailyMissionList[] daily_mission_list;

			public PeriodMissionList[] period_mission_list;

			public BeginnerMissionList[] beginner_mission_list;

			public SpecialMissionList[] special_mission_list;

			public int[] special_mission_purchased_group_id_list;

			public MainStoryMissionList[] main_story_mission_list;

			public CurrentMainStoryMission current_main_story_mission;

			public MemoryEventMissionList[] memory_event_mission_list;

			public AlbumMissionList[] album_mission_list;

			public MissionNotice mission_notice;
		}

		public CommonResponse data;
	}
}
