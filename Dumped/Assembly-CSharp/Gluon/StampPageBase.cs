/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StampPageBase : MonoBehaviour
	{
		// Fields
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
	
		// Constructors
		public StampPageBase();
	
		// Methods
		private void Start();
		public void ChangePageButton(int direction);
		private void OnCellButtonLongPressed(int index);
		private void UpdateViewPage();
		private void OnCellButtonPressed(int index);
		public void RemoveStamp();
		public bool ChangeStamp(int stampId);
		public int[] GetNowStampSetData();
		[CompilerGenerated]
		private void _Start_b__11_0(GameObject go, int index);
	}
}
