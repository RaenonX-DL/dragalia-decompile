using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class CharacterStateChargeCancelSyncBody : CharacterStateExtraSyncBody
	{
		[Key(0)]
		public bool keepCurrentAction;
	}
}
