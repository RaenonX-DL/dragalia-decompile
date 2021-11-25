using Cute.Http;

namespace Gluon.Http
{
	public class AmuletSetLockRequest : RequestCommon
	{
		public ulong amulet_key_id;

		public int is_lock;
	}
}
