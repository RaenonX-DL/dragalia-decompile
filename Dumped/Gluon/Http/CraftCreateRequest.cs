using Cute.Http;

namespace Gluon.Http
{
	public class CraftCreateRequest : RequestCommon
	{
		public int target_weapon_id;

		public int target_weapon_quantity;

		public int force_limit_break;

		public AtgenWeaponSetList[] weapon_set_list;
	}
}
