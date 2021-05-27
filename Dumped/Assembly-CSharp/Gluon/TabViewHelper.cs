/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TabViewHelper
	{
		// Fields
		private static Dictionary<string, int> tabViewIndexes;
		private static Dictionary<string, float> scrollPositions;
	
		// Constructors
		public TabViewHelper();
		static TabViewHelper();
	
		// Methods
		public static void SetTabCurIndex(string tabViewName, int curTabIndex);
		public static void SetTabScrollPos(string tabName, float scrollPos);
		public static int GetCurTabIndex(string tabViewName);
		public static float GetTabScrollPos(string tabName);
		public static void ResetTabViewCurrentIndex(string tabViewName);
		public static void ResetTabScrollPos(string tabName);
	}
}
