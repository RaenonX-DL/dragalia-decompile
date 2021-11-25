using Cute.Http;

namespace Gluon.Http
{
	public class ToolSignupRequest : RequestCommon
	{
		public string uuid;

		public string id_token;

		public string app_version;

		public string platform;

		public string hashcode;

		public int reset_count;

		public string eula_region;

		public string eula_lang;

		public int eula_version;

		public int privacy_policy_version;
	}
}
