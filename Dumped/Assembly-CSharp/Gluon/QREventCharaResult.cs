/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QREventCharaResult : QREventResultBase
	{
		// Fields
		private static readonly string seOpenHeart;
		private static readonly string seMoveHeart;
		private static readonly string seBigHeart;
		private static readonly string seMax;
		private static readonly string effNormalBg;
		private static readonly string effNormalFrontHeart;
		private static readonly string effMaxBg;
		private static readonly string effMaxFrontHeart;
		private EffectObject normalBgEffect;
		private EffectObject normalFrontEffect;
		private EffectObject maxBgEffect;
		private EffectObject maxFrontEffect;
		[SerializeField]
		private PointerEventHandler skipButtonEventHandler;
		[SerializeField]
		private Image charaBg;
		[SerializeField]
		private Image fadeBg;
		[SerializeField]
		private OutGameBgChara bgCharacter;
		[SerializeField]
		private Transform bgCharaOffset;
		[SerializeField]
		private UnityEngine.UI.Text intimacyText;
		[SerializeField]
		private UnityEngine.UI.Text gotIntimacyText;
		[SerializeField]
		private Gauge gauge;
		[SerializeField]
		private float pointCountUpDuration;
		[SerializeField]
		private float bgEffectPosY;
		[SerializeField]
		private Vector3 bgEffectScale;
		[SerializeField]
		private Transform heartAnimationParent;
		[SerializeField]
		private UnityEngine.UI.Text charaNameText;
		[SerializeField]
		private UnityEngine.UI.Text charaTalk;
		[SerializeField]
		private float contentAnimationSpeed;
		private FlashPlayer heartFlashPlayer;
		private FlashPlayer gaugeEffectflashPlayer;
		private FlashPlayer glitterBurstflashPlayer;
		private QuestResultModel resultModel;
		private Sequence seq;
		private EventKindType eventType;
		private EventQuestTalkDataModel.TalkSet talkSet;
		private int eventGroupId;
		private int previousPoint;
		private bool isMax;
		private const float maxEffectWaitTime = 0.6f;
		private Tweener talkTweener;
		private bool blockTouchUntilStateChanged;
		private EventCharaResultState _state;
		[SerializeField]
		private int textAnimationDigits;
		private const float waitForNormalAnimation = 0.33333334f;
	
		// Properties
		private EventCharaResultState state { get; set; }
	
		// Nested types
		public enum EventCharaResultState
		{
			Undefined = 0,
			Start = 1,
			End = 2,
			MaxStart = 3,
			MaxWait = 4,
			MaxEnd = 5
		}
	
		[CompilerGenerated]
		private sealed class _PlayNormalAnimation_d__52 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QREventCharaResult __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayNormalAnimation_d__52(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass53_0
		{
			// Fields
			public QREventCharaResult __4__this;
			public FlashPlayer flashPlayer;
	
			// Constructors
			public __c__DisplayClass53_0();
	
			// Methods
			internal bool _PlayMaxAnimation_b__0();
			internal void _PlayMaxAnimation_b__1();
			internal void _PlayMaxAnimation_b__2();
			internal void _PlayMaxAnimation_b__3();
			internal void _PlayMaxAnimation_b__4();
		}
	
		[CompilerGenerated]
		private sealed class _PlayMaxAnimation_d__53 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QREventCharaResult __4__this;
			private __c__DisplayClass53_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayMaxAnimation_d__53(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _MaxEffectWait_d__54 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QREventCharaResult __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _MaxEffectWait_d__54(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass56_0
		{
			// Fields
			public QREventCharaResult __4__this;
			public CharaDataElement charaElement;
			public Action endCallback;
	
			// Constructors
			public __c__DisplayClass56_0();
	
			// Methods
			internal void _UpdateGauge_b__0(float value);
			internal void _UpdateGauge_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass62_0
		{
			// Fields
			public Action completeCallback;
	
			// Constructors
			public __c__DisplayClass62_0();
	
			// Methods
			internal void _Talk_b__0();
		}
	
		// Constructors
		public QREventCharaResult();
		static QREventCharaResult();
	
		// Methods
		public static void LoadEffect();
		public static void ReleaseEffect();
		public void SetContent(QuestResultTopPage resultTop, QuestResultModel model);
		protected override void Start();
		private void SetBackKey(UnityAction action);
		[IteratorStateMachine]
		private IEnumerator PlayNormalAnimation();
		[IteratorStateMachine]
		private IEnumerator PlayMaxAnimation();
		[IteratorStateMachine]
		private IEnumerator MaxEffectWait();
		private void ShowNoteAnimation();
		private Sequence UpdateGauge(Action endCallback, bool needAnimation = true);
		private void SetGauge(float startValue, float endValue);
		public void OnScreenTouched();
		private void RunMaxExitAnimation();
		private void RunNormalExitAnimation();
		private void OnModuleEnd();
		private Tweener Talk(Action completeCallback);
		private Tweener Talk(bool useMaxText = false);
		[CompilerGenerated]
		private void _SetContent_b__49_0();
		[CompilerGenerated]
		private bool _PlayNormalAnimation_b__52_0();
		[CompilerGenerated]
		private void _PlayNormalAnimation_b__52_1();
		[CompilerGenerated]
		private void _PlayNormalAnimation_b__52_2();
		[CompilerGenerated]
		private void _PlayNormalAnimation_b__52_3();
		[CompilerGenerated]
		private void _PlayNormalAnimation_b__52_4();
		[CompilerGenerated]
		private void _PlayNormalAnimation_b__52_5();
		[CompilerGenerated]
		private void _PlayNormalAnimation_b__52_6();
		[CompilerGenerated]
		private void _PlayNormalAnimation_b__52_7();
		[CompilerGenerated]
		private void _OnScreenTouched_b__58_0();
		[CompilerGenerated]
		private void _RunMaxExitAnimation_b__59_0();
		[CompilerGenerated]
		private void _RunNormalExitAnimation_b__60_0();
	}
}
