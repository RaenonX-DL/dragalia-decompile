using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class PageScrollController<T> : MonoBehaviour
	{
		public GameObject originalCell;

		protected PageScrollRect pageScroll;

		protected List<PageScrollCell<T>> cells;

		protected List<T> dataList;

		protected int nowPageIndex;

		protected int createPageCount;

		protected bool pageLoopFlag;

		protected virtual void Start()
		{
		}

		protected void SetupPageScroll()
		{
		}

		protected virtual void ChangePage(int index)
		{
		}

		protected void OffsetScrollPage(int offset)
		{
		}

		public void SetMaxPage(int max)
		{
		}
	}
}
