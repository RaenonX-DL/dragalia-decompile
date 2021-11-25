using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class StampController : PageScrollController<StampPageData>
	{
		[SerializeField]
		private StampCarsouseIcons carsouselIcons;

		public UnityAction<int> pageButtonCallBack;

		private const int maxStampData = 24;

		private const string changePageSe = "SE_OUT_COMMON_0005";

		protected override void Start()
		{
		}

		private void OnIconPressed(int selectStampID)
		{
		}

		protected override void ChangePage(int index)
		{
		}

		public void ChangePageButton(int direction)
		{
		}

		private void UpdateCarsousel()
		{
		}
	}
}
