using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class VesselBombEventCountdownWithCoolTimeParameter : VesselBombEventParameterBase
	{
		[Required]
		[Key(0)]
		public CharacterId appender;

		[ActionId]
		[Key(1)]
		public int actionId;

		[SkillIdOrZero]
		[Key(2)]
		public int skillId;

		[ActionConditionId]
		[Key(3)]
		public int actionConditionId;
	}
}
