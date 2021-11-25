using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class GameStart : EventBase<GameStart>
	{
		[Required]
		[Key(1)]
		public int[] actorIds;
	}
}
