using System.Runtime.CompilerServices;

namespace Gluon
{
	public class PopupIconListView : TableViewController<PopupIconListData>
	{
		public const float cellHeight = 128f;

		public PopupIconViewCell iconViewCell;

		private GiftType showGiftType;

		private PopupIconListData.IconListData[] itemList;

		public PopupItemList rootScene
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void SetItemList(PopupIconListData.IconListData[] setList)
		{
		}

		protected override void Start()
		{
		}

		public void SetData()
		{
		}

		private void LoadData()
		{
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}
	}
}
