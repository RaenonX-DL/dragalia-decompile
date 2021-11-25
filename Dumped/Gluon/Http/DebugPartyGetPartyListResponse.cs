namespace Gluon.Http
{
	public class DebugPartyGetPartyListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenDebugDebugPartyList[] debug_party_list;
		}

		public CommonResponse data;
	}
}
