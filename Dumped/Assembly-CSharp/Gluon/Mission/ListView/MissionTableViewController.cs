/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Mission.ListView
{
	public class MissionTableViewController : TableViewController<MissionTableViewData>
	{
		// Fields
		public const float cellHeight = 168f;
		public const float cellWidth = 564f;
		public const float captionCellHeight = 56f;
		public const float textCellHeight = 50f;
		public const float cellAnimationDuration = 0.16666667f;
	
		// Properties
		public bool IsNoEntry { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public int missionId;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal bool _ScrollToMission_b__0(MissionTableViewData e);
		}
	
		// Constructors
		public MissionTableViewController();
	
		// Methods
		protected override void Awake();
		protected override TableViewCell<MissionTableViewData> CreateCellForIndex(int index);
		public void SetCellData(MissionTableViewData[] data);
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
		public void ShowCellAnimation();
		public void SkipCellAnimation();
		public void ScrollToMission(int missionId);
	}
}
