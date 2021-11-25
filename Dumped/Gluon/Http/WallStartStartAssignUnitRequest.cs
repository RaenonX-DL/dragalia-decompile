using Cute.Http;

namespace Gluon.Http
{
	public class WallStartStartAssignUnitRequest : RequestCommon
	{
		public int wall_id;

		public int wall_level;

		public PartySettingList[] request_party_setting_list;

		public ulong support_viewer_id;
	}
}
