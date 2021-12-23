namespace Gluon.Http
{
	public class DmodeDungeonStartResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public DmodeIngameData dmode_ingame_data;

			public int dmode_dungeon_state;
		}

		public CommonResponse data;
	}
}
