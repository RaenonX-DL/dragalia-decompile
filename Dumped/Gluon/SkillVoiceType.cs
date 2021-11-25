using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum SkillVoiceType
	{
		NONE,
		ATTACK,
		BUFF_SELF,
		BUFF_OTHERS,
		DEBUFF,
		RECOVERY,
		RECOVERY_SELF,
		ORIGIN_VOICE,
		ORIGIN_VOICE_JUDGEDBY_BASEID
	}
}
