/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PageScrollController<T> : MonoBehaviour
	{
		// Fields
		public GameObject originalCell;
		private PageScrollRect pageScroll;
		protected List<PageScrollCell<T>> cells;
		protected List<T> dataList;
		protected int nowPageIndex;
		protected int createPageCount;
		protected bool pageLoopFlag;
	
		// Constructors
		public PageScrollController();
	
		// Methods
		protected virtual void Start();
		protected void SetupPageScroll();
		protected virtual void ChangePage(int index);
		protected void OffsetScrollPage(int offset);
		public void SetMaxPage(int max);
	}
}
