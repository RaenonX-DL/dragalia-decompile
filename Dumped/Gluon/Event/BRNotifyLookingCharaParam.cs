using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class BRNotifyLookingCharaParam : BRNotifyEventParamBase
	{
		[Key(0)]
		public CharacterId targetCharacter;
	}
}
