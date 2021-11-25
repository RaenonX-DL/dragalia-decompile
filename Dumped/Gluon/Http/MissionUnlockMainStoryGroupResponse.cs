namespace Gluon.Http
{
	public class MissionUnlockMainStoryGroupResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public MainStoryMissionList[] main_story_mission_list;

			public UpdateDataList update_data_list;

			public AtgenBuildEventRewardEntityList[] main_story_mission_unlock_bonus_list;
		}

		public CommonResponse data;
	}
}
