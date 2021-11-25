namespace Gluon.Http
{
	public class WallRecordRecordResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public AtgenPlayWallDetail play_wall_detail;

			public AtgenBuildEventRewardEntityList[] wall_clear_reward_list;

			public AtgenWallDropReward wall_drop_reward;

			public AtgenWallUnitInfo wall_unit_info;
		}

		public CommonResponse data;
	}
}
