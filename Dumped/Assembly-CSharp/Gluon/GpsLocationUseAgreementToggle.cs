/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GpsLocationUseAgreementToggle : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Toggle useLocationInfoAgreementToggle;
		[SerializeField]
		private Button gpsMatchingButton;
		[SerializeField]
		public string prefsKeyLocationInfoUseGDPRAgreed;
		private Coroutine matchingButtonTask;
		private const int needParentAgreementAge = 15;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public CommonPopup popup;
			public UnityAction action;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _ShowUseLocationCautionPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal void _ShowUseLocationFailNoNAPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public CommonPopup popup;
			public UnityAction agreeAction;
			public UnityAction denyAction;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _ShowUseLocationConfirmPopup_b__0();
			internal void _ShowUseLocationConfirmPopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public CommonPopup popup;
			public UnityAction action;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _ShowUseLocationResultPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public CommonPopup errorPopup;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _OnLocationPermissionDenied_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public Action failedAction;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _DoMatchingButtonAction_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_1
		{
			// Fields
			public CommonPopup errorPopup;
			public __c__DisplayClass16_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass16_1();
	
			// Methods
			internal void _DoMatchingButtonAction_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _DoMatchingButtonAction_d__16 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Action failedAction;
			public GpsLocationUseAgreementToggle __4__this;
			public Action action;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DoMatchingButtonAction_d__16(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public GpsLocationUseAgreementToggle();
	
		// Methods
		private void Awake();
		private void ShowUseLocationCautionPopup(UnityAction action);
		private void ShowUseLocationFailNoNAPopup();
		private void ShowUseLocationConfirmPopup(UnityAction agreeAction, UnityAction denyAction);
		private void ShowUseLocationResultPopup(UnityAction action);
		public void OnUseLocationInfoAgreementToggleChanged(bool value);
		private void OnLocationPermissionDenied();
		private bool IsRequireGDPRAgreementRegion();
		private bool IsRequireGDPRAgreementAge();
		private void SetGpsLocationUseCheck(bool isChecked);
		public void OnGpsMatchingButtonPressed(Action action, Action failedAction = null);
		[IteratorStateMachine]
		private IEnumerator DoMatchingButtonAction(Action action, Action failedAction);
		[CompilerGenerated]
		private void _OnUseLocationInfoAgreementToggleChanged_b__10_0();
		[CompilerGenerated]
		private void _OnUseLocationInfoAgreementToggleChanged_b__10_1();
		[CompilerGenerated]
		private void _OnUseLocationInfoAgreementToggleChanged_b__10_2();
		[CompilerGenerated]
		private void _OnUseLocationInfoAgreementToggleChanged_b__10_5();
		[CompilerGenerated]
		private void _OnUseLocationInfoAgreementToggleChanged_b__10_7();
		[CompilerGenerated]
		private void _OnUseLocationInfoAgreementToggleChanged_b__10_8();
		[CompilerGenerated]
		private void _OnUseLocationInfoAgreementToggleChanged_b__10_9();
		[CompilerGenerated]
		private void _OnUseLocationInfoAgreementToggleChanged_b__10_6();
		[CompilerGenerated]
		private void _OnUseLocationInfoAgreementToggleChanged_b__10_3();
		[CompilerGenerated]
		private void _OnUseLocationInfoAgreementToggleChanged_b__10_4();
	}
}
