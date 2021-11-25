using Cute.Http;

namespace Gluon.Http
{
	public class DebugDungeonTraceRecordRequest : RequestCommon
	{
		public ulong viewer_id;

		public AtgenDebugDamageRecordLog damage_record_log;
	}
}
