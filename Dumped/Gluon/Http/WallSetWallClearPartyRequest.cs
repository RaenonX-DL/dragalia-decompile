using Cute.Http;

namespace Gluon.Http
{
	public class WallSetWallClearPartyRequest : RequestCommon
	{
		public int wall_id;

		public PartySettingList[] request_party_setting_list;
	}
}
