using Cute.Http;

namespace Gluon.Http
{
	public class DungeonFailRequest : RequestCommon
	{
		public string dungeon_key;

		public int fail_state;

		public int no_play_flg;
	}
}
