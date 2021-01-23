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
	[RequireComponent]
	public class InquiryMessageListController : TableViewController<Gluon.InquiryMessageListCellData>
	{
		// Fields
		public const float cellHeight = 96f;
		public int pageCellCountMax;
		public RectTransform pagerBase;
		public TabButton[] pagerButtons;
		private int pagerIndex;
		private int totalDataCount;
	
		// Constructors
		public InquiryMessageListController();
	
		// Methods
		protected override void Awake();
		public void LoadData(List<InquiryMessageListCellData> cellList, int pagerIndex);
		protected override void UpdateContents();
		protected override void UpdateContentSize();
		protected override TableViewCell<InquiryMessageListCellData> CreateCellForIndex(int index);
		protected override float GetCellHeightAtIndex(int index);
	}
}
