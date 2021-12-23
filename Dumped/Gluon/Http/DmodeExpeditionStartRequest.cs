using Cute.Http;

namespace Gluon.Http
{
	public class DmodeExpeditionStartRequest : RequestCommon
	{
		public int target_floor_num;

		public int[] chara_id_list;
	}
}
