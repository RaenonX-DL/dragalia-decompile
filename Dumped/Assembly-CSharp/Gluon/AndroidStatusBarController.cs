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
	public class AndroidStatusBarController
	{
		// Fields
		private static AndroidJavaObject plugin;
	
		// Properties
		public int visibleDisplayHeight { get; }
		public int displayHeight { get; }
		public int visibleDisplayWidth { get; }
		public int cutoutHeight { get; }
		public int displayWidth { get; }
		public int statusBarHeight { get; }
		public int navigationBarHeight { get; }
		public int realSizeHeight { get; }
		public int gpgsVersion { get; }
	
		// Constructors
		static AndroidStatusBarController();
		public AndroidStatusBarController();
	
		// Methods
		public bool isEnableEditSystemUI();
		public void Show();
		public bool isFullScreenMode();
		public void fullScreenMode();
		public bool isHideStatusBar();
		public void hideStatusBar();
		public bool isHideNavigationBar();
		public void hideNavigationBar();
		public void hideActionBar();
		public void showActionBar();
		public void RefreshLayout();
		public void ForceLayout();
		public void ClearFlags();
	}
}
