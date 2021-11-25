using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class BRNotifyGameEndEventParam : BRNotifyEventParamBase
	{
		[Required]
		[Key(0)]
		public CharacterId winnerCharacter;

		[Required]
		[Key(1)]
		public CharacterId lastDeadCharacter;
	}
}
