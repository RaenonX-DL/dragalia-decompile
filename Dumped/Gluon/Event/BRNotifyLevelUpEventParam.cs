using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class BRNotifyLevelUpEventParam : BRNotifyEventParamBase
	{
		[Required]
		[Key(0)]
		public CharacterId targetCharacter;

		[Required]
		[Key(1)]
		public int level;
	}
}
