using Cute.Http;

namespace Gluon.Http
{
	public class DungeonRecordRecordMultiRequest : RequestCommon
	{
		public PlayRecord play_record;

		public string dungeon_key;

		public ulong[] connecting_viewer_id_list;

		public int no_play_flg;
	}
}
