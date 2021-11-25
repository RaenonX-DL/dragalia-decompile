using Cute.Http;

namespace Gluon.Http
{
	public class WeaponSetLockRequest : RequestCommon
	{
		public ulong weapon_key_id;

		public int is_lock;
	}
}
