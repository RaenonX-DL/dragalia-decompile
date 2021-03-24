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
	public class OptionAndroidSettingPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public TabBase statusBarTab;
		public TabBase navigationBarTab;
		private bool statusBarOn;
		private bool navigationBarOn;
		private Action onClosed;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public Action<bool> toggleCallback;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _TabCallbackToToggle_b__0(int index, bool isFromUI);
		}
	
		// Constructors
		public OptionAndroidSettingPopup();
	
		// Methods
		public static OptionAndroidSettingPopup Create(Action onClosed);
		protected override void Start();
		public void OnAppliedAnyAction();
		private void BindEvent();
		private void TabCallbackToToggle(TabBase tab, Action<bool> toggleCallback);
		private void ApplyUIByOptionSetting();
		public void OnOKButtonPressed();
		public void OnStatusBarToggled(bool value);
		public void OnNavigationBarToggled(bool value);
	}
}
