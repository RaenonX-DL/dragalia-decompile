using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class TransSkill : EventBase<TransSkill>
	{
		[Key(1)]
		public CharacterId target;

		[Key(2)]
		public bool isDragon;

		[Key(3)]
		public int skillIndex;

		[Key(4)]
		public int currentSkillId;

		[Key(5)]
		public int transSkillId;
	}
}
