using Cute.Http;

namespace Gluon.Http
{
	public class DebugSummonUpdateSummonScoreAllRequest : RequestCommon
	{
		public ulong viewer_id;

		public int summon_score;

		public int summon_count;
	}
}
