/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StoryListController : TableViewController<Gluon.StoryListCellData>
	{
		// Fields
		public const float cellWidth = 275f;
		public const float cellHeight = 156f;
		public GameObject storyListBase;
	
		// Constructors
		public StoryListController();
	
		// Methods
		protected override void Start();
		public void LoadData(StoryListCategory dataType);
		private void LoadMainStoryData();
		private void LoadEventData();
		protected override void UpdateVisibleRect();
		protected override TableViewCell<StoryListCellData> CreateCellForIndex(int index);
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
		[CompilerGenerated]
		private void _CreateCellForIndex_b__8_0(int cellIndex);
	}
}
