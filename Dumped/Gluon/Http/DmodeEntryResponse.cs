namespace Gluon.Http
{
	public class DmodeEntryResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public DmodeInfo dmode_info;

			public DmodeCharaList[] dmode_chara_list;

			public DmodeServitorPassiveList[] dmode_servitor_passive_list;

			public DmodeDungeonInfo dmode_dungeon_info;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
