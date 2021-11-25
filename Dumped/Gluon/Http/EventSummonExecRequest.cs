using Cute.Http;

namespace Gluon.Http
{
	public class EventSummonExecRequest : RequestCommon
	{
		public int event_id;

		public int count;

		public int is_enable_stop_by_target;
	}
}
