using Cute.Http;

namespace Gluon.Http
{
	public class AmuletResetPlusCountRequest : RequestCommon
	{
		public ulong amulet_key_id;

		public int plus_count_type;
	}
}
