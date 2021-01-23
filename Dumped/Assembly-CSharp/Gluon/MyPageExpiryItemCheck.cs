/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPageExpiryItemCheck
	{
		// Fields
		private static long ticketWarningLastDisplayDate;
		private const int ticketWarningforceMoveSceneDays = 7;
		private const int ticketWarningStartDisplayDays = 2;
	
		// Nested types
		private class WarningExpiryItemInfo
		{
			// Fields
			public GiftType giftType;
			public int itemId;
			public string itemName;
			public TimeSpan span;
	
			// Constructors
			public WarningExpiryItemInfo(GiftType giftType, int itemId, string itemName, TimeSpan span);
	
			// Methods
			public bool ShouldForceMove();
			public void OnMoveButtonPressed();
			public string GetMoveButtonText();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<WarningExpiryItemInfo, TimeSpan> __9__4_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal TimeSpan _CheckAndShowExpriryWarning_b__4_0(WarningExpiryItemInfo x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0
		{
			// Fields
			public CommonPopup popup;
			public List<WarningExpiryItemInfo> warningList;
			public WarningExpiryItemInfo firstItem;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal void _CreateWarningPopupOneByOne_b__0();
			internal void _CreateWarningPopupOneByOne_b__1();
		}
	
		// Constructors
		public MyPageExpiryItemCheck();
		static MyPageExpiryItemCheck();
	
		// Methods
		public static void CheckAndShowExpriryWarning();
		private static void CreateWarningPopupOneByOne(List<WarningExpiryItemInfo> warningList);
	}
}
