namespace Gluon
{
	public class AlbumSummonModel
	{
		private static AlbumSummonModel instance;

		public GiftType giftType;

		public int masterId;

		public Rarity rarity;

		public static AlbumSummonModel Instance => null;

		public static void DeleteInstance()
		{
		}

		public static bool IsInstanceEmpty()
		{
			return default(bool);
		}

		private AlbumSummonModel()
		{
		}

		static AlbumSummonModel()
		{
		}

		public void Create(GiftType type, int id, Rarity rarity)
		{
		}
	}
}
