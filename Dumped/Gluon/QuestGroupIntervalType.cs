using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum QuestGroupIntervalType
	{
		NONE = 0,
		DAILY = 1,
		WEEKEND = 2,
		SUNDAY = 3,
		MONDAY = 4,
		TUESDAY = 5,
		WEDNESDAY = 6,
		THURSDAY = 7,
		FRIDAY = 8,
		SATURDAY = 9,
		MON_AND_SUN = 10,
		MON_AND_TUE = 11,
		MON_AND_WED = 12,
		MON_AND_THU = 13,
		MON_AND_FRI = 14,
		MON_AND_SAT = 0xF,
		WEEKEND_AND_MON = 17,
		WEEKEND_AND_TUE = 18,
		WEEKEND_AND_WED = 19,
		WEEKEND_AND_THU = 20,
		WEEKEND_AND_FRI = 21,
		WEEKEND_AND_SAT = 22,
		EVENT_SCHEDULE = 23,
		MON_THU_SAT_SUN = 24,
		TUE_FRI_SAT_SUN = 25,
		MON_WED_SAT_SUN = 26,
		WED_FRI_SAT_SUN = 27,
		TUE_THU_SAT_SUN = 28,
		SAT_AND_SUN = 29
	}
}
