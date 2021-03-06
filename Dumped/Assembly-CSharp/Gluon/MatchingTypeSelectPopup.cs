﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MatchingTypeSelectPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEvent publicButtonPressed;
		[SerializeField]
		public UnityEvent privateButtonPressed;
		[SerializeField]
		public UnityEvent bgButtonPressed;
		[SerializeField]
		private RectTransform rectTransTouchLayer;
		public UnityEvent gpsSearchButtonPressed;
		[SerializeField]
		private GpsLocationUseAgreementToggle useLocationInfoAgreementToggle;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _FitSize_d__7 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MatchingTypeSelectPopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _FitSize_d__7(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public MatchingTypeSelectPopup();
	
		// Methods
		protected override void Start();
		[IteratorStateMachine]
		private IEnumerator FitSize();
		public void OnPublicButtonPressed();
		public void OnPrivateButtonPressed();
		public void OnGpsMatchingButtonPressed();
		public void OnBgButtonPressed();
		[CompilerGenerated]
		private void _OnGpsMatchingButtonPressed_b__10_0();
	}
}
