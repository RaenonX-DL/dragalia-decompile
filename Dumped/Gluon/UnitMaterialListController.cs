namespace Gluon
{
	public class UnitMaterialListController : CommonIconListController
	{
		public GrowthMaterialSelectScene scene;

		public int CellCount => default(int);

		protected override CommonIconListCellData CreateDragonCellData(ulong keyId, int decoNum)
		{
			return null;
		}

		protected override CommonIconListCellData CreateWeaponCellData(ulong keyId, int decoNum)
		{
			return null;
		}

		protected override CommonIconListCellData CreateAmuletCellData(ulong keyId, int decoNum)
		{
			return null;
		}

		public GrowMaterialCellData GetCellDataByKeyId(ulong keyId)
		{
			return null;
		}

		public void UpdateCellByKeyIds(ulong[] keyIds)
		{
		}

		public void NotUseMaterialIconLock(bool isExpItemLock, bool isHpPlusLock, bool isAtkPlusLock)
		{
		}

		public void AllListIconLock()
		{
		}

		public void AllListIconUnlock()
		{
		}

		public void IconListSelectClear()
		{
		}

		public GrowMaterialCellData[] GetAutoSelectMaterial()
		{
			return null;
		}

		public void UpdateCellDataSelectNumber()
		{
		}
	}
}
