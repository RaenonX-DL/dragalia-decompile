using Cute.Http;

namespace Gluon.Http
{
	public class DungeonSkipStartMultipleQuestRequest : RequestCommon
	{
		public int party_no;

		public AtgenRequestQuestMultipleList[] request_quest_multiple_list;

		public ulong support_viewer_id;
	}
}
