using Cute.Http;

namespace Gluon.Http
{
	public class UserRecoverStaminaByStoneRequest : RequestCommon
	{
		public int recovery_type;

		public int recovery_quantity;

		public int payment_type;
	}
}
