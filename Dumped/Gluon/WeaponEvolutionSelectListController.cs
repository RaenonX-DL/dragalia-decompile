namespace Gluon
{
	public class WeaponEvolutionSelectListController : CommonIconListController
	{
		public bool isShowAllTarget;

		public int CellCount => default(int);

		protected override CommonIconListCellData CreateWeaponCellData(ulong keyIdOrInvalidId, int decoNum)
		{
			return null;
		}

		protected override void CustomSort()
		{
		}
	}
}
