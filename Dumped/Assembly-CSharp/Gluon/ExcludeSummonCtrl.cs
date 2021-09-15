/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ExcludeSummonCtrl : TableViewController<Gluon.ExcludeSummonCellData>
	{
		// Fields
		[SerializeField]
		private AnimationListOneCol listAnimation;
		[SerializeField]
		private float delayFrame;
		[SerializeField]
		public UnityEngine.UI.Text canExcludeNum;
		public GiftType giftType;
		private const float cellHeight = 148f;
		private List<ExcludeSummonCellData> excludeSummonCellDataList;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public int entityId;
			public ExcludeSummonCtrl __4__this;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal bool _ReloadContents_b__0(ExcludeSummonCellData x);
		}
	
		// Constructors
		public ExcludeSummonCtrl();
	
		// Methods
		protected override void Awake();
		public void Init(GiftType giftType, List<ulong> idList);
		public void ReloadContents(List<ulong> idList);
		public List<ExcludeSummonCellData> GetSortTableData();
		public List<ExcludeSummonCellData> GetTableData();
		public void SetAllExcludeSetting(bool excludeSetting);
		public void AllUpdateCell();
		protected override TableViewCell<ExcludeSummonCellData> CreateCellForIndex(int index);
		protected override float GetCellHeightAtIndex(int index);
		public void StartEnterAnimation();
		public void StartExitAnimation();
	}
}
