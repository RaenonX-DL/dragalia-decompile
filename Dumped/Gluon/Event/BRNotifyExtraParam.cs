using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class BRNotifyExtraParam : BRNotifyEventParamBase
	{
		[Required]
		[Key(0)]
		public CharacterId targetCharacter;

		[Required]
		[Key(1)]
		public int value1;

		[Required]
		[Key(2)]
		public int value2;

		[Required]
		[Key(3)]
		public int value3;
	}
}
