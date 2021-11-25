using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class RequestGuard : EventBase<RequestGuard>
	{
		[Key(1)]
		public ushort requestId;

		[Key(2)]
		public CharacterId targetEnemy;
	}
}
