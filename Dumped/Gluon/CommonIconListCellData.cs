namespace Gluon
{
	public class CommonIconListCellData
	{
		public enum State
		{
			None,
			Selected
		}

		public CommonIconListType baseType;

		public ElementalType element;

		public State state;

		public bool isOutButton;

		public int rarity;

		public int id;

		public ulong baseKeyId;

		public int level;

		public int additionalMaxLevel;

		public int buildupCount;

		public int hpPlus;

		public int atkPlus;

		public int limitBreak;

		public int limitOver;

		public bool isEmptySpace;

		public int decoNum;

		public bool showLockImage;

		public bool isUpdateCell;

		public CommonIconListCaption.CaptionInfo captionInfo;

		public int delayIndex;
	}
}
