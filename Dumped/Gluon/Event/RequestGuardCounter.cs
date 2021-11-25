using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class RequestGuardCounter : EventBase<RequestGuardCounter>
	{
		[Key(1)]
		public CharacterId counterExecEnemy;
	}
}
