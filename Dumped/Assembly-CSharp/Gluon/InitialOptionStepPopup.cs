/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InitialOptionStepPopup : PopupBase
	{
		// Fields
		public static OptionModel.Setting setting;
		public PageViewBase pageView;
		public UIAnimationPublisher publisher;
		public ButtonPressedMarkEventSender nextButtonPressedMark;
		public ButtonPressedMarkEventSender prevButtonPressedMark;
		private Action onCompleted;
	
		// Nested types
		public enum PageIndex
		{
			Vocal = 0,
			Graphic = 1,
			UILayout = 2,
			Max = 3
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public CommonPopup popup;
			public UnityEvent backKeyEvent;
			public Action onCompleted;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal void _CreateModule_b__0();
			internal void _CreateModule_b__1();
			internal void _CreateModule_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_1
		{
			// Fields
			public CommonPopup quitPopup;
			public __c__DisplayClass7_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass7_1();
	
			// Methods
			internal void _CreateModule_b__3();
			internal void _CreateModule_b__4();
		}
	
		// Constructors
		public InitialOptionStepPopup();
		static InitialOptionStepPopup();
	
		// Methods
		public static void CreateModule(Action onCompleted);
		protected override void Start();
		private void SetPageContent(GameObject page, int index);
		public static void CreateFinalConfirmPopup(Action onCompelte, InitialOptionStepPopup thisPopup);
		public void OnNextButtonPressed();
		public void OnReturnButtonPressed();
		private static void ReApplySetting();
		public static void OnVocalSettingChanged(int value);
		public static void OnGraphicQualityChanged(int value);
		public static void OnUILayoutChanged(bool value);
	}
}
