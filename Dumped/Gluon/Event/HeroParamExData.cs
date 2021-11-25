using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class HeroParamExData
	{
		[Key(0)]
		public int sequenceNumber;

		[Key(1)]
		public int limitOverCount;

		[Key(2)]
		public int brSpecialSkillId;
	}
}
