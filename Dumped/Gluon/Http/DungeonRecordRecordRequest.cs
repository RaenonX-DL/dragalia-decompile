using Cute.Http;

namespace Gluon.Http
{
	public class DungeonRecordRecordRequest : RequestCommon
	{
		public PlayRecord play_record;

		public string dungeon_key;

		public int repeat_state;

		public string repeat_key;
	}
}
