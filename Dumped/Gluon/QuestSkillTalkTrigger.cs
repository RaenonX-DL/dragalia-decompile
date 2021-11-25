using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum QuestSkillTalkTrigger
	{
		NONE,
		QUESTSKILL,
		RECAST_RATE_HIGER,
		PRAY_OBJECT_DESTORY,
		MIASMA_BEGIN,
		RESERVE_02,
		RESERVE_03
	}
}
