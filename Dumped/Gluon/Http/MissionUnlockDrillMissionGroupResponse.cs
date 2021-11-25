namespace Gluon.Http
{
	public class MissionUnlockDrillMissionGroupResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public DrillMissionList[] drill_mission_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
