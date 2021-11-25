using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum PrizeType
	{
		platinum = 1,
		gold,
		silver,
		bonze,
		fifthPrize,
		sixthPrize
	}
}
