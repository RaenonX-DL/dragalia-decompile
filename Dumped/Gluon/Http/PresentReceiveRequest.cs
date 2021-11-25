using Cute.Http;

namespace Gluon.Http
{
	public class PresentReceiveRequest : RequestCommon
	{
		public ulong[] present_id_list;

		public int is_limit;
	}
}
