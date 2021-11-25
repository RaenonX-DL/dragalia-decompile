using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class CharacterStateCounterActionSyncBody : CharacterStateExtraSyncBody
	{
		[Key(0)]
		public int actionId;
	}
}
