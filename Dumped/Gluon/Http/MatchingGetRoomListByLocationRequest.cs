using Cute.Http;

namespace Gluon.Http
{
	public class MatchingGetRoomListByLocationRequest : RequestCommon
	{
		public string region;

		public int quest_type;

		public float latitude;

		public float longitude;

		public int compatible_id;
	}
}
