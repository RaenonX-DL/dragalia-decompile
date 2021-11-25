using Cute.Http;

namespace Gluon.Http
{
	public class AmuletBuildupRequest : RequestCommon
	{
		public ulong base_amulet_key_id;

		public GrowMaterialList[] grow_material_list;
	}
}
