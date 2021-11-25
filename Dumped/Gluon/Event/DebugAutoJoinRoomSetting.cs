using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class DebugAutoJoinRoomSetting
	{
		[Key(0)]
		public bool disableBot;

		[Key(1)]
		public int[] botBRSkinId;

		[Key(2)]
		public bool isDebugMatching;

		[Key(3)]
		public int minMatchingWithBotsPlayerCount;

		[Key(4)]
		public float mathingWithBotsWaitSec;

		[Key(5)]
		public int matchingWithoutBotsPlayerCount;

		[Key(6)]
		public int locationPattern;
	}
}
