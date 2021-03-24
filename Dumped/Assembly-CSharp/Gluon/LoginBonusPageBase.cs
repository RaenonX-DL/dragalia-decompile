/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public abstract class LoginBonusPageBase : PageBase
	{
		// Fields
		[SerializeField]
		protected Canvas uiCanvasFront;
		[SerializeField]
		protected Canvas uiCanvasMiddle;
		[SerializeField]
		protected Canvas uiCanvasBack;
		[SerializeField]
		private GameObject bonusItemIconTemplate;
		[SerializeField]
		private GameObject tapToNextItem;
		[SerializeField]
		private PointerEventHandler screenTapPointerEventHandler;
		[SerializeField]
		protected RawImage bgImage;
		private const string localizedBGPathTemplate = "Images/OutGame/LoginBonus/Background/Localized/EventLoginBonus_{0:D4}";
		protected LoginBonusScene scene;
		protected List<LoginBonusRewardElement> rewardList;
		protected List<GameObject> itemIcons;
		protected int getDayIndex;
		protected int nextDayIndex;
		protected int totalDays;
		protected Coroutine execDemoCoroutine;
		protected bool isSkipButtonPushed;
		private bool isScreenTapped;
		protected bool isEnableScreenTapped;
		protected static readonly Vector2 iconPositionConvertScale;
	
		// Nested types
		protected enum DemoKind
		{
			Today = 0,
			DailyGift = 1,
			Tomorrow = 2,
			Nof = 3
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<LoginBonusRewardElement> __9__25_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _CreateRewardList_b__25_0(LoginBonusRewardElement a, LoginBonusRewardElement b);
		}
	
		[CompilerGenerated]
		private sealed class _SkipDemoCoroutine_d__34 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LoginBonusPageBase __4__this;
			public Action endCallback;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SkipDemoCoroutine_d__34(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitScreenTapped_d__39 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LoginBonusPageBase __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitScreenTapped_d__39(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitForSecondsOrScreenTapped_d__40 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float second;
			public LoginBonusPageBase __4__this;
			private float _startTime_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForSecondsOrScreenTapped_d__40(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitUntilOrScreenTapped_d__41 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Func<bool> func;
			public LoginBonusPageBase __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitUntilOrScreenTapped_d__41(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0
		{
			// Fields
			public Action onFinish;
	
			// Constructors
			public __c__DisplayClass43_0();
	
			// Methods
			internal void _LoadNewEnrollmentPage_b__0();
		}
	
		// Constructors
		protected LoginBonusPageBase();
		static LoginBonusPageBase();
	
		// Methods
		public override void OnPageBecomeActive(object data);
		protected virtual void Start();
		protected virtual void Reset();
		protected void InitCamera();
		protected void SetupBG();
		public abstract void OnNextLoginBonus();
		protected static List<LoginBonusRewardElement> CreateRewardList(int loginBonusId);
		protected void SetupContents();
		public void TeardownContents();
		protected virtual void ResetDemo();
		protected virtual void ProcOnDemoEnd();
		protected virtual Vector2 GetIconPosition(int day, int total);
		protected abstract Vector2[] GetIconPositionArray(int total);
		protected static void replaceFlashPlayerPlaneImage(FlashPlayer player, List<KeyValuePair<string, Material>> planeNameAndReplaceMaterialPairs);
		[IteratorStateMachine]
		protected IEnumerator SkipDemoCoroutine(Action endCallback);
		protected void StopExecDemoCoroutine();
		public virtual void OnScreenTapped();
		protected void SetEnableTapped(bool enable);
		protected bool IsScreenTapped();
		[IteratorStateMachine]
		protected IEnumerator WaitScreenTapped();
		[IteratorStateMachine]
		protected IEnumerator WaitForSecondsOrScreenTapped(float second);
		[IteratorStateMachine]
		protected IEnumerator WaitUntilOrScreenTapped(Func<bool> func);
		protected void EnableTapToNext(bool isEnable = true);
		protected void LoadNewEnrollmentPage(int id, GiftType giftType, Action onFinish);
	}
}
