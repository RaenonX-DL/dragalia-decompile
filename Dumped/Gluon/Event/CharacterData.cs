using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class CharacterData : EventBase<CharacterData>
	{
		[Key(1)]
		public int playerId;

		[Key(2)]
		public HeroParam[] heroParams;

		[Key(3)]
		public HeroParam[] unusedHeroParams;

		[Key(4)]
		public HeroParamExData[] heroParamExs;
	}
}
