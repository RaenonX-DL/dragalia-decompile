using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum SummonPrizeRank
	{
		NONE,
		SUMMON_PRIZE_RANK_1,
		SUMMON_PRIZE_RANK_2,
		SUMMON_PRIZE_RANK_3,
		SUMMON_PRIZE_RANK_4,
		SUMMON_PRIZE_RANK_5,
		SUMMON_PRIZE_RANK_6
	}
}
