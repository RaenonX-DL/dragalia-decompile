using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class DenyGuard : EventBase<DenyGuard>
	{
		[Key(1)]
		public ushort requestId;

		[Key(2)]
		public CharacterId guardExecEnemy;
	}
}
