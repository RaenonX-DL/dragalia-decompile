using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum UnitDetailContentType
	{
		None,
		StatusInfo,
		AbilityInfo,
		ManaCircleInfo,
		DragonizeInfo,
		Equip,
		Equip2,
		LegendAbilityCrest,
		Flavor,
		SkillInfo,
		SkillAndAbilityInfo,
		ExAbilityInfo
	}
}
