/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class LoginBonusCharacterControl : MonoBehaviour
	{
		// Fields
		public const string animatorAndAnimationPath = "Animations/OutGame/LoginBonus";
		private static readonly int animTriggerToAppear;
		private static readonly int animTriggerToIntroduce;
		private static readonly int animTriggerToMove;
		private static readonly int animTriggerToIdle;
		private static readonly int animTriggerToOut;
		private static readonly int animTriggerTapSkip;
		[SerializeField]
		private RuntimeAnimatorController controller;
		private GameObject chara;
		private SkinnedMeshRenderer skinRenderer;
		private Animator animator;
		private Action callback;
		private SimpleCharacterModel model;
		private bool isAlreadyProcOnMoveToStandPositionEnd;
		private SimpleCharacterDirectFacialAnimation facialAnimation;
		private MouthRateControl[] mouthRateList;
		private int lastRateIndex;
		private bool lastRatePositive;
		private EffectObject[] effectGameObjectArray;
		private static readonly string[] effectFileName;
		private bool _isLoaded;
	
		// Properties
		public bool IsLoaded { get; }
	
		// Nested types
		private class MouthRateControl
		{
			// Fields
			public int index16;
			public float rate;
	
			// Constructors
			public MouthRateControl(int index16, float rate);
		}
	
		private enum EffectKind
		{
			Appear = 0,
			Spirit = 1,
			Scales = 2,
			Nof = 3
		}
	
		[CompilerGenerated]
		private sealed class _Load_d__26 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LoginBonusCharacterControl __4__this;
			public Action finishCallback;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Load_d__26(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public EffectObject eff;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal bool _PlayAllBindEffect_b__1();
			internal bool _PlayAllBindEffect_b__2();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__29_0;
			public static Func<bool> __9__30_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _PlayAllBindEffect_b__29_0();
			internal bool _PlayPopEffect_b__30_0();
		}
	
		[CompilerGenerated]
		private sealed class _PlayAllBindEffect_d__29 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LoginBonusCharacterControl __4__this;
			private __c__DisplayClass29_0 __8__1;
			private GameObject _obj_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayAllBindEffect_d__29(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public EffectObject eff;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal bool _PlayPopEffect_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _PlayPopEffect_d__30 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LoginBonusCharacterControl __4__this;
			private GameObject _obj_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayPopEffect_d__30(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _DelayAction_d__39 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float sec;
			public Action action;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DelayAction_d__39(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public LoginBonusCharacterControl();
		static LoginBonusCharacterControl();
	
		// Methods
		private void Awake();
		[IteratorStateMachine]
		public IEnumerator Load(Action finishCallback);
		private int GetMouthIndex16(int frameCount);
		private GameObject LoadCharacter();
		[IteratorStateMachine]
		private IEnumerator PlayAllBindEffect();
		[IteratorStateMachine]
		public IEnumerator PlayPopEffect();
		private EffectObject PlayBindEffect(GameObject bodyObject, EffectKind kind, string bindJointName);
		private void DestroyAllEffect();
		private void DestroyEffect(EffectKind kind);
		public void ResetToIdle();
		public void MoveStart(Action callback);
		public void OnMoveStart();
		public void OnMoveToStandPositionEnd(bool isTapSkip);
		private void OnShowCharacter();
		[IteratorStateMachine]
		private IEnumerator DelayAction(float sec, Action action);
		public void IntroduceStart(Action callback);
		public void SetMouthTalkState(bool isOpen);
		public void OnIntroduceTrigger();
		public void ToOut();
		public void SetMouthTrigger(string triggerName);
		public void OnTapSkip();
		[CompilerGenerated]
		private void _OnMoveToStandPositionEnd_b__37_0();
	}
}
