/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestWallTotalLevelRewardGuidePopup : CommonPopup
	{
		// Fields
		private const int questWallId = 21601;
		private static bool isPopUp;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0
		{
			// Fields
			public Action<bool> onProcessEnd;
	
			// Constructors
			public __c__DisplayClass2_0();
	
			// Methods
			internal void _CreateIfNeededAsync_b__0(bool toEvent);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0
		{
			// Fields
			public Action<bool> onDoneAction;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _Create_b__0();
			internal void _Create_b__1();
		}
	
		// Constructors
		public QuestWallTotalLevelRewardGuidePopup();
		static QuestWallTotalLevelRewardGuidePopup();
	
		// Methods
		public static void CreateIfNeededAsync(Action<bool> onProcessEnd);
		private static void Create(Action<bool> onDoneAction);
		private static void EnterEvent(int id);
	}
}
