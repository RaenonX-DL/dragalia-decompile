using Cute.Http;

namespace Gluon.Http
{
	public class DebugGuildUpdateUserRequest : RequestCommon
	{
		public ulong viewer_id;

		public int last_attend_time;

		public int penalty_end_time;
	}
}
