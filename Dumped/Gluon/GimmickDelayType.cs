using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum GimmickDelayType
	{
		NON,
		FIX,
		ADD,
		RANDOM
	}
}
