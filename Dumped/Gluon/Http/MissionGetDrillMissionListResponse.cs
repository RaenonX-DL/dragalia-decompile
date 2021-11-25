namespace Gluon.Http
{
	public class MissionGetDrillMissionListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public DrillMissionList[] drill_mission_list;

			public DrillMissionGroupList[] drill_mission_group_list;

			public MissionNotice mission_notice;
		}

		public CommonResponse data;
	}
}
