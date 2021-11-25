using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class CharacterStateAdditionalInputCountSyncBody : CharacterStateExtraSyncBody
	{
		[Key(0)]
		public int actionId;

		[Key(1)]
		public int loopCount;
	}
}
