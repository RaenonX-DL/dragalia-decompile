using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class NextEnemyGroup : EventBase<NextEnemyGroup>
	{
		[Key(1)]
		public int mapIndex;

		[Key(2)]
		public int groupId;
	}
}
