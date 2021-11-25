namespace Gluon
{
	public class GrowthBaseSelectListController : CommonDualListTableViewController
	{
		public TutorialDataManager.GrowthTutorialType tutorialType;

		public ulong[] limitBreakTagets;

		public bool isShowEquipableCount;

		private GrowthEquipBaseListCellData tutorialTargetCellData;

		private float defaultScrollPosY;

		protected override CommonIconListCellData CreateCharacterCellData(int keyId, int decoNum)
		{
			return null;
		}

		protected override CommonIconListCellData CreateAmuletCellData(ulong keyIdOrInvalidId, int decoNum)
		{
			return null;
		}

		protected override CommonIconListCellData CreateDragonCellData(ulong keyId, int decoNum)
		{
			return null;
		}

		protected override CommonIconListCellData CreateWeaponCellData(ulong keyId, int decoNum)
		{
			return null;
		}

		protected override void CustomSort()
		{
		}

		public void ChangeCrestLabelInfo()
		{
		}

		protected override void UpdateContentSize()
		{
		}

		public void UpdateCellListData()
		{
		}

		public void SetDefaultScrollPosY(float posY)
		{
		}
	}
}
