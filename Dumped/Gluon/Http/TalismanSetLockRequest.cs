using Cute.Http;

namespace Gluon.Http
{
	public class TalismanSetLockRequest : RequestCommon
	{
		public ulong talisman_key_id;

		public int is_lock;
	}
}
