using Cute.Http;

namespace Gluon.Http
{
	public class DungeonSkipStartRequest : RequestCommon
	{
		public int quest_id;

		public int party_no;

		public ulong support_viewer_id;

		public int play_count;

		public int bet_count;
	}
}
