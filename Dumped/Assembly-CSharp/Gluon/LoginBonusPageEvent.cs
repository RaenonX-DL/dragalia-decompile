/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using DG.Tweening;
using FLATOUT.Main;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class LoginBonusPageEvent : LoginBonusPageBase
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text PeriodText;
		[SerializeField]
		private Transform periodTextBase;
		[SerializeField]
		private Transform bonusPanelTransform;
		[SerializeField]
		private Transform frontCanvasFrameTransform;
		[SerializeField]
		private Button skipButton;
		private EffectObject effect;
		private const string paperEffectPath = "EFF_SCE_2D_CMN_106";
		private const string loginbonusSoundGroup = "LOGINBONUS";
		private const string paperSoundPath = "SE_LOGINBONUS_0008";
		private AudioPlayback paperSoundPlayback;
		private const string flashPathTemplate = "Prefabs/OutGame/LoginBonus/Flash/{0}";
		private const int yOffset = 115;
		private static readonly Vector2[][] bonusIconPositions;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__15_0;
			public static TweenCallback __9__22_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _PlayPaperSE_b__15_0();
			internal void _ExecDemoCoroutine_b__22_0();
		}
	
		[CompilerGenerated]
		private sealed class _PlayPaperSE_d__15 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LoginBonusPageEvent __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayPaperSE_d__15(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public bool isEnd;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _ExecDemoCoroutine_b__1();
			internal void _ExecDemoCoroutine_b__2();
			internal bool _ExecDemoCoroutine_b__3();
			internal bool _ExecDemoCoroutine_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_1
		{
			// Fields
			public bool isEnd;
			public LoginBonusPageEvent __4__this;
	
			// Constructors
			public __c__DisplayClass22_1();
	
			// Methods
			internal void _ExecDemoCoroutine_b__5();
			internal bool _ExecDemoCoroutine_b__6();
		}
	
		[CompilerGenerated]
		private sealed class _ExecDemoCoroutine_d__22 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LoginBonusPageEvent __4__this;
			private __c__DisplayClass22_0 __8__1;
			public Action endCallback;
			private int _demoDayIndex_5__2;
			private LoginBonusRewardElement _reward_5__3;
			private LoginBonusItemIcon _icon_5__4;
			private FlRoot _root_5__5;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ExecDemoCoroutine_d__22(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlaySpecialFlashSE_d__23 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float triggerTime;
			public string seName;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlaySpecialFlashSE_d__23(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public LoginBonusPageEvent();
		static LoginBonusPageEvent();
	
		// Methods
		private void Init();
		public override void OnPageBecomeActive(object data);
		public override void OnPageBecomeInActive();
		private void PlayEffect();
		[IteratorStateMachine]
		private IEnumerator PlayPaperSE();
		private void SetupPeriodText();
		private Vector2 ConvertPhotoshopPositionToLocalPosition(Vector2 pos);
		public void OnSkipButtonPressed();
		public override void OnNextLoginBonus();
		protected override void Reset();
		private bool ShouldInjectFlash(LoginBonusRewardElement elem);
		[IteratorStateMachine]
		private IEnumerator ExecDemoCoroutine(Action endCallback);
		[IteratorStateMachine]
		private IEnumerator PlaySpecialFlashSE(string seName, float triggerTime);
		protected override Vector2 GetIconPosition(int day, int total);
		protected override Vector2[] GetIconPositionArray(int total);
		[CompilerGenerated]
		private void _PlayEffect_b__14_0(GameObject effectObj);
	}
}
