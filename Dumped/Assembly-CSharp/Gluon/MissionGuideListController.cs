/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MissionGuideListController : TableViewController<Gluon.MissionGuideListCellData>
	{
		// Fields
		public float cellWidth;
		public float cellHeight;
		[CompilerGenerated]
		private int _currentContentDataId_k__BackingField;
	
		// Properties
		public int currentContentDataId { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum ContentType
		{
			None = 0,
			MainStory = 1,
			Event = 2,
			EventOr = 3,
			WallLevel = 4,
			MultiCondition = 5
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<MissionGuideListCellData, int> __9__7_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _LoadGuideList_b__7_0(MissionGuideListCellData p);
		}
	
		// Constructors
		public MissionGuideListController();
	
		// Methods
		public void LoadGuideList();
		private void AutoScrollToCurrentContent();
		public static bool IsClearContent(MainStoryGuideElement mainStoryGuideElement);
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
	}
}
