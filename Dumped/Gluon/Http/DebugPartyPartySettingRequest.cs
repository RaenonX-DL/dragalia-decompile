using Cute.Http;

namespace Gluon.Http
{
	public class DebugPartyPartySettingRequest : RequestCommon
	{
		public ulong viewer_id;

		public DebugPartySettingList[] party_setting_list;
	}
}
