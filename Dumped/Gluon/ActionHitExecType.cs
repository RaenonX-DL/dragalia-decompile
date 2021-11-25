using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum ActionHitExecType
	{
		NONE,
		DAMAGE,
		HEAL,
		CUSTOM,
		TRANS,
		DAMAGE_OBJ,
		NODAMAGE,
		HEAL_SP,
		MYSELF,
		HEAL_SP_HUMANONLY,
		DUMMY_DAMAGE,
		HEAL_SP_DRAGONONLY
	}
}
