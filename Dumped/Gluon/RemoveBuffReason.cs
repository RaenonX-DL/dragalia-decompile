using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 1)]
	public enum RemoveBuffReason : byte
	{
		Death = 0,
		GameEnd = 1,
		Overwrite = 2,
		Hit = 3,
		Exhausted = 4,
		AbnormalStatus = 5,
		ActionCondition = 6,
		Transform = 7,
		TransNextSkill = 8,
		CurseOfEmptiness = 9,
		PartySwitch = 10,
		LevelUp = 11,
		LevelDown = 12,
		Other = byte.MaxValue
	}
}
