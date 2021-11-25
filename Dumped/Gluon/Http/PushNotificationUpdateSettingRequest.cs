using Cute.Http;

namespace Gluon.Http
{
	public class PushNotificationUpdateSettingRequest : RequestCommon
	{
		public string region;

		public string lang;

		public string uuid;
	}
}
