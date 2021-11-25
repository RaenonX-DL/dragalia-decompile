using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class RequestCounter : EventBase<RequestCounter>
	{
		[Key(1)]
		public CharacterId counterExecEnemy;

		[Key(2)]
		public CharacterId counterTargetChara;
	}
}
