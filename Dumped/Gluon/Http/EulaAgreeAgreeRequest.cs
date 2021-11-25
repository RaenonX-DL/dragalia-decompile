using Cute.Http;

namespace Gluon.Http
{
	public class EulaAgreeAgreeRequest : RequestCommon
	{
		public string id_token;

		public string region;

		public string lang;

		public int eula_version;

		public int privacy_policy_version;

		public string uuid;
	}
}
