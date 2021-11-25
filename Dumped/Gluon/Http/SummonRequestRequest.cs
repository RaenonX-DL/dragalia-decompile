using Cute.Http;

namespace Gluon.Http
{
	public class SummonRequestRequest : RequestCommon
	{
		public int summon_id;

		public int exec_type;

		public int exec_count;

		public int payment_type;
	}
}
