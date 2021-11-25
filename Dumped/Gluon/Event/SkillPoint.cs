using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class SkillPoint : EventBase<SkillPoint>
	{
		[Required]
		[Key(1)]
		public CharacterId character;

		[Required]
		[Key(2)]
		public int[] sp;
	}
}
