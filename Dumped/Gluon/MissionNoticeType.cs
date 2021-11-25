using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum MissionNoticeType
	{
		Daily,
		Period,
		Normal,
		Beginner,
		StoryMission,
		MemoryEvent,
		Drill,
		Album,
		Special
	}
}
