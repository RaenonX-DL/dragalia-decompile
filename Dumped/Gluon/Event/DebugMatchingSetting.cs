using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class DebugMatchingSetting
	{
		[Key(0)]
		public int trueQuestId;

		[Key(1)]
		public int dungeonType;
	}
}
