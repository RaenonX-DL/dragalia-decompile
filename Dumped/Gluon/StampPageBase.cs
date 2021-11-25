using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class StampPageBase : MonoBehaviour
	{
		public UnityAction<int> pageButtonCallBack;

		public UnityAction<int> pageButtonLongPressCallBack;

		public UnityAction pageChangeCallBack;

		public StampSetData nowStampSet;

		[SerializeField]
		private PageViewBase stampPageView;

		[SerializeField]
		private StampPageCell stampPageCell;

		private List<StampPageData> stampDataList;

		private int oldSelectedPageIndex;

		private int oldSelectedCellIndex;

		private int selectPageIconIndex;

		private int createPageCount;

		private void Start()
		{
		}

		public void ChangePageButton(int direction)
		{
		}

		private void OnCellButtonLongPressed(int index)
		{
		}

		private void UpdateViewPage()
		{
		}

		private void OnCellButtonPressed(int index)
		{
		}

		public void RemoveStamp()
		{
		}

		public bool ChangeStamp(int stampId)
		{
			return default(bool);
		}

		public int[] GetNowStampSetData()
		{
			return null;
		}
	}
}
