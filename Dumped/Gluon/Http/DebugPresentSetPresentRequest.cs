using Cute.Http;

namespace Gluon.Http
{
	public class DebugPresentSetPresentRequest : RequestCommon
	{
		public ulong viewer_id;

		public int entity_type;

		public int entity_id;

		public int entity_quantity;

		public bool is_limit;
	}
}
