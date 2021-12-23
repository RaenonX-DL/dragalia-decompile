namespace Gluon.Http
{
	public class DmodeGetDataResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public DmodeInfo dmode_info;

			public DmodeCharaList[] dmode_chara_list;

			public DmodeServitorPassiveList[] dmode_servitor_passive_list;

			public DmodeDungeonInfo dmode_dungeon_info;

			public DmodeStoryList[] dmode_story_list;

			public DmodeExpedition dmode_expedition;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public int current_server_time;
		}

		public CommonResponse data;
	}
}
