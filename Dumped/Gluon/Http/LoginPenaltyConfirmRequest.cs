using Cute.Http;

namespace Gluon.Http
{
	public class LoginPenaltyConfirmRequest : RequestCommon
	{
		public int penalty_type;

		public int report_id;
	}
}
