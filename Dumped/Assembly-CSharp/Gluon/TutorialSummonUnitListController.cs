/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TutorialSummonUnitListController : CommonIconListController
	{
		// Fields
		private const string seDecide = "SE_OUT_COMMON_0001";
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<CommonIconListCellData, CommonIconListType> __9__1_0;
			public static Func<CommonIconListCellData, int> __9__1_1;
			public static Func<CommonIconListCellData, ElementalType> __9__1_2;
			public static Func<CommonIconListCellData, int> __9__1_3;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal CommonIconListType _Init_b__1_0(CommonIconListCellData p);
			internal int _Init_b__1_1(CommonIconListCellData p);
			internal ElementalType _Init_b__1_2(CommonIconListCellData p);
			internal int _Init_b__1_3(CommonIconListCellData p);
		}
	
		// Constructors
		public TutorialSummonUnitListController();
	
		// Methods
		public void Init();
		private void OnIconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void TutorialFlagReset();
	}
}
