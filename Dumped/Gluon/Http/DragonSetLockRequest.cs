using Cute.Http;

namespace Gluon.Http
{
	public class DragonSetLockRequest : RequestCommon
	{
		public ulong dragon_key_id;

		public int is_lock;
	}
}
