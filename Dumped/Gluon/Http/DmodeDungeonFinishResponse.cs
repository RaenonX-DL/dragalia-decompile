namespace Gluon.Http
{
	public class DmodeDungeonFinishResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int dmode_dungeon_state;

			public DmodeIngameResult dmode_ingame_result;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
