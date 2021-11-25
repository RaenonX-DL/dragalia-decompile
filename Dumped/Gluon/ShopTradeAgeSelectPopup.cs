using System;
using System.Runtime.InteropServices;

namespace Gluon
{
	public class ShopTradeAgeSelectPopup : PopupBase
	{
		public enum AgeGroup
		{
			None,
			Underaged,
			Adult
		}

		private Action<AgeGroup> onAgeSelected;

		private Action onClose;

		public static ShopTradeAgeSelectPopup Create(Action<AgeGroup> onAgeSelected, [Optional] Action onClose)
		{
			return null;
		}

		public void OnCancel()
		{
		}

		public void OnUnderagedSelected()
		{
		}

		public void OnAdultSelected()
		{
		}

		public void OnAgeSelected(AgeGroup ageGroup)
		{
		}
	}
}
