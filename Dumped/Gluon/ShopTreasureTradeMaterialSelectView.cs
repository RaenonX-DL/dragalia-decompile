using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class ShopTreasureTradeMaterialSelectView : ShopTradePanelBase
	{
		private UnityAction onDecideButtonPressedCallback;

		private string captionTitle;

		private CaptionCanvas.IconType captionIconType;

		public static ShopTreasureTradeMaterialSelectView Create(Transform parent, ShopTradeScene scene)
		{
			return null;
		}

		private void Start()
		{
		}

		public void SetCaptionInfo(string title, CaptionCanvas.IconType iconType)
		{
		}

		public void OnCellButtonPressed(int groupId)
		{
		}

		public void SetOnDecideButtonPressedCallback(UnityAction callback)
		{
		}

		public void OnDecideButtonPressed()
		{
		}
	}
}
