using Cute.Http;

namespace Gluon.Http
{
	public class WallStartStartRequest : RequestCommon
	{
		public int wall_id;

		public int wall_level;

		public int party_no;

		public ulong support_viewer_id;
	}
}
