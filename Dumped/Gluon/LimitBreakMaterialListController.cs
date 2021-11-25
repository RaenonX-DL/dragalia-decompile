namespace Gluon
{
	public class LimitBreakMaterialListController : CommonIconListController
	{
		public int growthBaseId;

		public GrowthBaseType growthBaseType;

		public TutorialDataManager.GrowthTutorialType tutorialType;

		protected override void Awake()
		{
		}

		protected override CommonIconListCellData CreateDragonCellData(ulong keyIdOrInvalidId, int decoNum)
		{
			return null;
		}

		protected override CommonIconListCellData CreateWeaponCellData(ulong keyIdOrInvalidId, int decoNum)
		{
			return null;
		}

		protected override CommonIconListCellData CreateAmuletCellData(ulong keyIdOrInvalidId, int decoNum)
		{
			return null;
		}

		public void AllListIconLock()
		{
		}

		public void AllListIconUnlock()
		{
		}

		public void UpdateCellByKeyIds(ulong[] keyIds)
		{
		}

		public void UpdateCellDataSelectNumber(ulong[] keyIds)
		{
		}

		private void AddItemIcon()
		{
		}

		private void AddSphereMaterialIcon()
		{
		}

		protected override void AddExceptionButton(CommonIconListType type)
		{
		}

		public void UpdateContentByIndex(int index)
		{
		}
	}
}
