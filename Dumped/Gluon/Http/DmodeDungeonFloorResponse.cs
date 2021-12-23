namespace Gluon.Http
{
	public class DmodeDungeonFloorResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int dmode_dungeon_state;

			public DmodeFloorData dmode_floor_data;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
