using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class HostMigrationEvent : EventBase<HostMigrationEvent>
	{
		[Key(1)]
		public int nextHostActorId;
	}
}
