using Cute.Http;

namespace Gluon.Http
{
	public class WeaponLimitBreakRequest : RequestCommon
	{
		public ulong base_weapon_key_id;

		public GrowMaterialList[] grow_material_list;
	}
}
