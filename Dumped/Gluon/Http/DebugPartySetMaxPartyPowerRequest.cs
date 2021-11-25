using Cute.Http;

namespace Gluon.Http
{
	public class DebugPartySetMaxPartyPowerRequest : RequestCommon
	{
		public ulong viewer_id;

		public int party_power;
	}
}
