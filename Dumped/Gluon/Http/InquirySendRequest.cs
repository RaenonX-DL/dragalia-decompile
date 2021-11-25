using Cute.Http;

namespace Gluon.Http
{
	public class InquirySendRequest : RequestCommon
	{
		public string opinion_text;

		public int opinion_type;

		public string language_code;

		public string region_code;

		public int occurred_at;
	}
}
