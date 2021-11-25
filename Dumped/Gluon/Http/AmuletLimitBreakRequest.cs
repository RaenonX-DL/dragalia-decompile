using Cute.Http;

namespace Gluon.Http
{
	public class AmuletLimitBreakRequest : RequestCommon
	{
		public ulong base_amulet_key_id;

		public GrowMaterialList[] grow_material_list;
	}
}
