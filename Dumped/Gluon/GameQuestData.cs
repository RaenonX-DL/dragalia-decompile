using Gluon.Http;

namespace Gluon
{
	public class GameQuestData : IngameQuestData
	{
		public int QuestId => default(int);

		public int PlayCount => default(int);

		public bool IsMissionClear1 => default(bool);

		public bool IsMissionClear2 => default(bool);

		public bool IsMissionClear3 => default(bool);
	}
}
