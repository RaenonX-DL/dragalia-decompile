using Cute.Http;

namespace Gluon.Http
{
	public class WeaponResetPlusCountRequest : RequestCommon
	{
		public ulong weapon_key_id;

		public int plus_count_type;
	}
}
