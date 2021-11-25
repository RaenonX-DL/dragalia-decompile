using Cute.Http;

namespace Gluon.Http
{
	public class WeaponBuildupRequest : RequestCommon
	{
		public ulong base_weapon_key_id;

		public GrowMaterialList[] grow_material_list;
	}
}
