using Cute.Http;

namespace Gluon.Http
{
	public class DungeonReceiveQuestBonusRequest : RequestCommon
	{
		public int quest_event_id;

		public int is_receive;

		public int receive_bonus_count;
	}
}
