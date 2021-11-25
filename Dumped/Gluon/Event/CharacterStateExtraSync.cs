using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class CharacterStateExtraSync : EventBase<CharacterStateExtraSync>
	{
		[Key(1)]
		public CharacterId character;

		[Key(2)]
		public byte state;

		[Key(3)]
		public CharacterStateExtraSyncBody body;
	}
}
