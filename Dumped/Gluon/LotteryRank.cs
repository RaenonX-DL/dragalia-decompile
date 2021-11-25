using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum LotteryRank
	{
		NONE,
		LOTTERY_RANK_1,
		LOTTERY_RANK_2,
		LOTTERY_RANK_3,
		LOTTERY_RANK_4,
		LOTTERY_RANK_5,
		LOTTERY_RANK_6,
		LOTTERY_RANK_7
	}
}
