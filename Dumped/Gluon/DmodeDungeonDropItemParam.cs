namespace Gluon
{
	public class DmodeDungeonDropItemParam
	{
		public int instanceId;

		public int dataId;

		private DmodeDungeonDropItemParam()
		{
		}

		public DmodeDungeonDropItemParam(int instanceId, int dataId)
		{
		}

		public DmodeDungeonItemType GetItemType()
		{
			return default(DmodeDungeonItemType);
		}

		public int GetRarity()
		{
			return default(int);
		}
	}
}
