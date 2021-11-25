using Cute.Http;

namespace Gluon.Http
{
	public class MissionReceiveDrillRewardRequest : RequestCommon
	{
		public int[] drill_mission_id_list;

		public int[] drill_mission_group_id_list;
	}
}
