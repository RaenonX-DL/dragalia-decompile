using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum GrowResultDialogType
	{
		None,
		DiffParam,
		PowerupSkill,
		GetSkill2,
		MaxLimitLevel,
		GoLimitBreak,
		NeedLimitMaterial,
		MaxPlus,
		PowerupAbility,
		PowerupSkillAndAbility
	}
}
