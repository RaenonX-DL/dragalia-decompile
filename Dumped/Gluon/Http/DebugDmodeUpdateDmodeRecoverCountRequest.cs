using Cute.Http;

namespace Gluon.Http
{
	public class DebugDmodeUpdateDmodeRecoverCountRequest : RequestCommon
	{
		public ulong viewer_id;

		public int recovery_count;
	}
}
