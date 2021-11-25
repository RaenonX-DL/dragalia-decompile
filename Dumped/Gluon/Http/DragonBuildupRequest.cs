using Cute.Http;

namespace Gluon.Http
{
	public class DragonBuildupRequest : RequestCommon
	{
		public ulong base_dragon_key_id;

		public GrowMaterialList[] grow_material_list;
	}
}
