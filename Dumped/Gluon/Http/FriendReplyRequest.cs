using Cute.Http;

namespace Gluon.Http
{
	public class FriendReplyRequest : RequestCommon
	{
		public ulong friend_id;

		public int reply;
	}
}
