/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BoxSummonPage : EventQuestPageBase
	{
		// Fields
		public const int ResetItemSequence = 5;
		[SerializeField]
		private Transform edgeToEdgeTrans;
		[SerializeField]
		private Button resetButton;
		[SerializeField]
		private Button summonButton;
		[SerializeField]
		private GameObject eventSummonReward;
		[SerializeField]
		private Image eventSummonRewardImage2;
		[SerializeField]
		private RectTransform eventSummonRewardMover;
		[SerializeField]
		private Image eventSummonPickup2;
		[SerializeField]
		private Image eventSummonPickup1Bg;
		[SerializeField]
		private Image eventSummonPickup1Text;
		[SerializeField]
		private Image eventSummonPickup1Duration;
		[SerializeField]
		private GameObject rewardItemTemplate;
		[SerializeField]
		private UnityEngine.UI.Text durationText;
		[SerializeField]
		private UnityEngine.UI.Text pointRemain;
		[SerializeField]
		private UnityEngine.UI.Text pointCost;
		[SerializeField]
		private BoxSummonItem[] summonItems;
		private bool isSetupContents;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<AtgenBoxSummonDetail> __9__23_0;
			public static Func<BoxSummonDataElement, bool> __9__26_0;
			public static Action<PageBase> __9__29_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _SetupSummonData_b__23_0(AtgenBoxSummonDetail a, AtgenBoxSummonDetail b);
			internal bool _SetupPointCost_b__26_0(BoxSummonDataElement item);
			internal void _OnSummonButtonTouched_b__29_2(PageBase nextPage);
		}
	
		[CompilerGenerated]
		private sealed class _WaitForSetupContents_d__32 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BoxSummonPage __4__this;
			public AnimationUICanvas.AnimationPattern animationPattern;
			public Action onAnimationDone;
			public Action onCutOff;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForSetupContents_d__32(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public BoxSummonPage();
	
		// Methods
		protected override void Awake();
		private void Start();
		public override void ResetSummonData();
		public override void OnPageBecomeActive(object data);
		private void SetupContents();
		private void SetupEventSummonMainReward();
		private void SetupSummonData();
		private void SetupEventPeriod();
		private void SetupPointReamin();
		private void SetupPointCost();
		private void ResetSummonButton();
		public void OnContentButtonTouched();
		public void OnSummonButtonTouched();
		public void OnBackButtonTouched();
		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		[IteratorStateMachine]
		private IEnumerator WaitForSetupContents(AnimationPattern animationPattern, Action onAnimationDone, Action onCutOff = null);
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		protected override int GetMaxExecCount();
		[CompilerGenerated]
		private void _Start_b__18_0();
		[CompilerGenerated]
		private void _OnSummonButtonTouched_b__29_0(bool execDemo);
		[CompilerGenerated]
		private void _OnSummonButtonTouched_b__29_1();
		[CompilerGenerated]
		private bool _WaitForSetupContents_b__32_0();
		[CompilerGenerated]
		[DebuggerHidden]
		private void __n__0(AnimationPattern pattern, Action onAnimationDone, Action onCutOff);
	}
}
