using Cute.Http;

namespace Gluon.Http
{
	public class DebugUserUpdateTutorialStatusRequest : RequestCommon
	{
		public ulong viewer_id;

		public int tutorial_status;
	}
}
