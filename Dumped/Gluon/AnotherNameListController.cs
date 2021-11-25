using Gluon.Http;
using Gluon.Master;

namespace Gluon
{
	public class AnotherNameListController : TableViewController<AnotherNameCellData>
	{
		private enum EmblemDataCategory
		{
			None,
			Chara,
			Dragon,
			Weapon,
			Quest,
			Other
		}

		public float cellWidth;

		public float cellHeight;

		public NameListBase nameListBase;

		private AnotherNameSortData sortData;

		protected override void Start()
		{
		}

		public void LoadData(EmblemList[] allNameList)
		{
		}

		private void SetupAnotherNameCellData(EmblemDataElement masterEmblemData, out AnotherNameCellData cellData)
		{
		}

		public void SetSortData(AnotherNameSortData newSortData)
		{
		}

		public void Reload()
		{
		}

		public void ClearList()
		{
		}

		public void UpdateNameCell(int nameId)
		{
		}

		protected override void UpdateVisibleRect()
		{
		}

		protected override TableViewCell<AnotherNameCellData> CreateCellForIndex(int index)
		{
			return null;
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		protected override float GetCellWidthAtIndex(int index)
		{
			return default(float);
		}
	}
}
