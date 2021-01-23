/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SysMessageUI : CommonDialog
	{
		// Fields
		private Param param;
		private bool isShowCloseAppPop;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public CommonPopup popup;
			public SysMessageUI __4__this;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _CreateCloseAppPop_b__0();
			internal void _CreateCloseAppPop_b__1();
		}
	
		// Constructors
		public SysMessageUI();
	
		// Methods
		public static SysMessageUI CreateSysMessage(GameObject parent);
		protected override void Initialize();
		public void Open(bool modal, string text, string title = "", int fontSize = 0, bool raycast = true);
		protected override void ExecFirstButtonPressed();
		private void CreateCloseAppPop();
	}
}
