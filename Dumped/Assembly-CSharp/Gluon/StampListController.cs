/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StampListController : TableViewController<Gluon.StampListData>
	{
		// Fields
		public const float cellWidth = 114f;
		public const float cellHeight = 114f;
		public GameObject listFrameObject;
		private ScrollRect _scrollRect;
		private int tapIconIndex;
	
		// Properties
		public ScrollRect stampSelectScrollRect { get; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<StampListData> __9__8_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _LoadData_b__8_0(StampListData a, StampListData b);
		}
	
		// Constructors
		public StampListController();
	
		// Methods
		protected override void Start();
		public void LoadData(StampList[] allStampDatas);
		protected override TableViewCell<StampListData> CreateCellForIndex(int index);
		public void UpdateListIcon(int stampId, bool nowSelectFlag, bool tapSelectFlag);
		public bool IsNowSelect(int stampId);
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
		[CompilerGenerated]
		private void _CreateCellForIndex_b__9_0(int cellIndex);
		[CompilerGenerated]
		private void _CreateCellForIndex_b__9_1(int cellIndex);
	}
}
