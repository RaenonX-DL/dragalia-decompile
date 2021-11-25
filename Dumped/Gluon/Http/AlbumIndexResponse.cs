namespace Gluon.Http
{
	public class AlbumIndexResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenAlbumQuestPlayRecordList[] album_quest_play_record_list;

			public AlbumDragonData[] album_dragon_list;

			public AlbumPassiveNotice album_passive_update_result;

			public AtgenCharaHonorList[] chara_honor_list;

			public UpdateDataList update_data_list;
		}

		public CommonResponse data;
	}
}
