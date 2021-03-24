/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TutorialSummonPage : TutorialSummonPageBase
	{
		// Fields
		[SerializeField]
		private Transform edgeToEdgeTrans;
		private bool isSetupContents;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _WaitForSetupContents_d__6 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TutorialSummonPage __4__this;
			public AnimationUICanvas.AnimationPattern animationPattern;
			public Action onAnimationDone;
			public Action onCutOff;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForSetupContents_d__6(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _CreateDetailPopup_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<PageBase> __9__11_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnSummonButtonPressed_b__11_1(PageBase nextPage);
		}
	
		// Constructors
		public TutorialSummonPage();
	
		// Methods
		protected override void Awake();
		public override void OnPageBecomeActive(object data);
		private void SetupContents();
		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		[IteratorStateMachine]
		private IEnumerator WaitForSetupContents(AnimationPattern animationPattern, Action onAnimationDone, Action onCutOff = null);
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public void OnOddsButtonPressed();
		public void OnDetailButtonPressed();
		private void CreateDetailPopup();
		public void OnSummonButtonPressed();
		[CompilerGenerated]
		private void _OnPageBecomeActive_b__3_0();
		[CompilerGenerated]
		private bool _WaitForSetupContents_b__6_0();
		[CompilerGenerated]
		[DebuggerHidden]
		private void __n__0(AnimationPattern pattern, Action onAnimationDone, Action onCutOff);
		[CompilerGenerated]
		private void _OnSummonButtonPressed_b__11_0();
	}
}
