using UnityEngine.Events;

namespace Gluon
{
	public class ItemListCellData
	{
		public enum CellType
		{
			Icon,
			Caption,
			Funds,
			NoneIconLine,
			NoneCaptionLine,
			NoneFundsLine,
			TextOnly,
			NoneTextOnlyLine
		}

		public int itemId;

		public int ItemNum;

		public GiftType giftType;

		public string captionString;

		public string messageString;

		public UnityAction<ItemListCellData> pressedCallback;

		public int useLimit;

		public CellType cellType;
	}
}
