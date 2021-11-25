using Cute.Http;

namespace Gluon.Http
{
	public class CraftAssembleRequest : RequestCommon
	{
		public ulong weapon_key_id;

		public int target_weapon_id;

		public GrowMaterialList[] assemble_item_list;

		public AtgenWeaponSetList[] weapon_set_list;
	}
}
