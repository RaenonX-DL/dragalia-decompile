namespace Gluon
{
	public class BattleRoyalCharaSkinIconListCellData : CommonIconListCellData
	{
		public enum SkinType
		{
			None,
			Equipable,
			Relesable,
			ShopOnly,
			NoRelease
		}

		public SkinType skinType;

		public int specialSkillId;

		public bool isOnSale;
	}
}
