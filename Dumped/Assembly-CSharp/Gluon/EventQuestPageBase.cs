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
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventQuestPageBase : PageBase
	{
		// Fields
		public readonly Color resetButtonNormalColor;
		public readonly Color resetButtonDisableColor;
	
		// Properties
		public EventQuestScene eventQuestScene { get; }
		public bool isSummonDataReady { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public Action closeCallback;
			public EventQuestPageBase __4__this;
			public Action okCallback;
			public Action __9__2;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _OnButtonResetTouched_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_1
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass9_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass9_1();
	
			// Methods
			internal void _OnButtonResetTouched_b__0();
			internal void _OnButtonResetTouched_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_2
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass9_2();
	
			// Methods
			internal void _OnButtonResetTouched_b__4();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<BoxSummonDataElement, bool> __9__9_3;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _OnButtonResetTouched_b__9_3(BoxSummonDataElement item);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public CommonPopup popup;
			public Action callback;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _ShowResetCompleteDialog_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public Action onLeaving;
			public EventQuestPageBase __4__this;
	
			// Constructors
			public __c__DisplayClass13_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_1
		{
			// Fields
			public Scene scene;
			public __c__DisplayClass13_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass13_1();
	
			// Methods
			internal void _ShowItemDetail_b__0(Scene unitDetalScene);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public EventQuestPageBase __4__this;
			public Action<bool> onOkCallback;
			public Action onCloseCallback;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _ShowSelectCountDialog_b__0();
			internal void _ShowSelectCountDialog_b__2(int count, bool execDemo, bool isTillResetItem);
			internal void _ShowSelectCountDialog_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_1
		{
			// Fields
			public bool execDemo;
			public __c__DisplayClass15_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass15_1();
	
			// Methods
			internal void _ShowSelectCountDialog_b__3(EventSummonExecResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public EventQuestPageBase __4__this;
			public Action onComplete;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _RequestBoxSummonData_b__0(EventSummonGetDataResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public EventQuestPageBase __4__this;
			public Action callback;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _RequestResetSummon_b__0(EventSummonResetResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0
		{
			// Fields
			public bool isLoaded;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal void _LoadSummonBgScene_b__0();
			internal bool _LoadSummonBgScene_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _LoadSummonBgScene_d__20 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadSummonBgScene_d__20(int __1__state);
	
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
			public Action onComplete;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _RequestEventPointRewardData_b__0(BuildEventReceiveBuildPointRewardResponse response);
			internal void _RequestEventPointRewardData_b__1(Clb01EventReceiveClb01PointRewardResponse response);
			internal void _RequestEventPointRewardData_b__2(CombatEventReceiveEventPointRewardResponse response);
			internal void _RequestEventPointRewardData_b__3(BattleRoyalEventReceiveEventCyclePointRewardResponse response);
		}
	
		// Constructors
		public EventQuestPageBase();
	
		// Methods
		public override void OnPageBecomeActive(object data);
		public virtual void OnPresentReceived();
		public virtual void ResetSummonData();
		public void OnButtonResetTouched(Action okCallback = null, Action closeCallback = null);
		private int GetSummonSequence();
		public void UpdateResetButton(Button resetButton);
		private void ShowResetCompleteDialog(Action callback);
		public void ShowItemDetail(SummonResultItemData itemData, Action onLeaving = null);
		public void SetButtonInteractable(Button button, bool f, UnityEngine.UI.Text text);
		public void ShowSelectCountDialog(Action<bool> onOkCallback, Action onCloseCallback = null);
		public void RequestBoxSummonData(Action onComplete);
		public void RequestResetSummon(Action callback);
		protected void UpdateAfterConnection(bool isSummonResult);
		public override void ShowPage(bool toShow);
		[IteratorStateMachine]
		public IEnumerator LoadSummonBgScene();
		public void UnloadSummonBgScene();
		public static void RequestEventPointRewardData(Action onComplete);
		protected virtual int GetMaxExecCount();
	}
}
