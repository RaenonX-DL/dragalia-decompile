using Cute.Http;

namespace Gluon.Http
{
	public class MatchingGetRoomListByQuestIdRequest : RequestCommon
	{
		public string region;

		public int quest_id;

		public int compatible_id;
	}
}
