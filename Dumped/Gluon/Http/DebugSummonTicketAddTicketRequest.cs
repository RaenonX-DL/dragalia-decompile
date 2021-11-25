using Cute.Http;

namespace Gluon.Http
{
	public class DebugSummonTicketAddTicketRequest : RequestCommon
	{
		public int ticket_id;

		public int count;

		public ulong viewer_id;
	}
}
