using Cute.Http;

namespace Gluon.Http
{
	public class PartySetPartySettingRequest : RequestCommon
	{
		public int party_no;

		public PartySettingList[] request_party_setting_list;

		public string party_name;

		public int is_entrust;

		public int entrust_element;
	}
}
