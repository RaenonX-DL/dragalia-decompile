using Cute.Http;

namespace Gluon.Http
{
	public class RaidEventReceiveRaidPointRewardRequest : RequestCommon
	{
		public int raid_event_id;

		public int[] raid_event_reward_id_list;
	}
}
