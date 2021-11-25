using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum BuffType
	{
		NONE,
		HP,
		ATTACK,
		DEFENSE,
		CRITICAL
	}
}
