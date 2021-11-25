using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum QuestEntryType
	{
		NONE = 0,
		SET_CHARA = 1001,
		FORT_PLANT_LV = 1002,
		CHARA_FRIENDSHIP_POINT = 1003
	}
}
