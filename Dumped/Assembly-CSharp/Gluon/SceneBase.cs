/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using NPF;
using NPF.NPFWrapper;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SceneBase : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public bool hasHeader;
		[SerializeField]
		public bool hasFooter;
		[SerializeField]
		public bool isDateChangeCheckDisableOnTransition;
		[SerializeField]
		public bool isDateChangeCheckDisableOnResume;
		[SerializeField]
		private MaintenanceFunctionType[] funcTypes;
		[SerializeField]
		public bool hasExitAnimation;
		[SerializeField]
		public bool multiTouchEnabled;
		[Header]
		[SerializeField]
		public int sceneExitFrameCount;
		public static bool isInitialSceneForDevelopment;
		private int defaultCanvasPlaneDistance;
		[HideInInspector]
		public GameObject backButtonObject;
		private int popupCount;
		protected bool isPopupOpened;
		public bool isPageControlNeeded;
		[CompilerGenerated]
		private PageController _pageCtrl_k__BackingField;
		[CompilerGenerated]
		private SceneNameDefine.PageName _nextPageName_k__BackingField;
		[CompilerGenerated]
		private SceneNameDefine.PageName _previousPageName_k__BackingField;
		public bool isCalledDateChangeEvent;
		public bool isCalledMaihtenanceEvent;
		private bool isOptionalScene;
		protected bool isPlayTutorial;
		public UnityAction webViewCloseCallback;
		private static bool _isPromotedItemOnPending;
		private const int constPromotedItemOKStatusWaitCount = 2;
		private static int promotedItemOKStatusCount;
	
		// Properties
		public PageController pageCtrl { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public PageBase curPage { get; }
		public SceneNameDefine.PageName nextPageName { [CompilerGenerated] get; [CompilerGenerated] set; }
		public SceneNameDefine.PageName previousPageName { [CompilerGenerated] get; [CompilerGenerated] set; }
		public static bool isPromotedItemOnPending { get; set; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__40_0;
			public static Func<bool> __9__40_1;
			public static Func<bool> __9__40_2;
			public static Func<bool> __9__42_0;
			public static Func<bool> __9__43_0;
			public static Func<bool> __9__49_0;
			public static Func<bool> __9__52_0;
			public static Action __9__77_0;
			public static Action __9__78_0;
			public static Action __9__79_3;
			public static Action<List<NPFPayment.ProductInfo>> __9__79_1;
			public static Action<NPFErrorParam> __9__79_2;
			public static Action<ShopGetListResponse> __9__79_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _WaitPrevSceneExit_b__40_0();
			internal bool _WaitPrevSceneExit_b__40_1();
			internal bool _WaitPrevSceneExit_b__40_2();
			internal bool _ResetHeaderCanvasSettings_b__42_0();
			internal bool _ResetFooterCanvasSettings_b__43_0();
			internal bool _TouchGuardWaitCoroutine_b__49_0();
			internal bool _RemoveTouchGuardWaitCoroutine_b__52_0();
			internal void _CreatePromotedIAPCommonNGPopup_b__77_0();
			internal void _CreatePromotedIAPTutorialNGPopup_b__78_0();
			internal void _CreatePromotedIAP_b__79_0(ShopGetListResponse res);
			internal void _CreatePromotedIAP_b__79_1(List<NPFPayment.ProductInfo> infoList);
			internal void _CreatePromotedIAP_b__79_3();
			internal void _CreatePromotedIAP_b__79_2(NPFErrorParam error);
		}
	
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExit_d__40 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SceneBase __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitPrevSceneExit_d__40(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ResetHeaderCanvasSettings_d__42 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public int waitframe;
			public SceneBase __4__this;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ResetHeaderCanvasSettings_d__42(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ResetFooterCanvasSettings_d__43 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public int waitframe;
			public SceneBase __4__this;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ResetFooterCanvasSettings_d__43(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _SetHeaderFooterCanvasPlaneDistanceCoroutine_d__45 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SceneBase __4__this;
			public int distance;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetHeaderFooterCanvasPlaneDistanceCoroutine_d__45(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _TouchGuardWaitCoroutine_d__49 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float duration;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _TouchGuardWaitCoroutine_d__49(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _RemoveTouchGuardWaitCoroutine_d__52 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _RemoveTouchGuardWaitCoroutine_d__52(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ExitAnimationCoroutine_d__63 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SceneBase __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ExitAnimationCoroutine_d__63(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public SceneBase();
		static SceneBase();
	
		// Methods
		protected SceneModelBase StartSceneBase(bool isAddedScene = false, bool isInitGraphicParam = false);
		[IteratorStateMachine]
		private IEnumerator WaitPrevSceneExit();
		private void LoadBaseScenes();
		[IteratorStateMachine]
		protected IEnumerator ResetHeaderCanvasSettings(int waitframe);
		[IteratorStateMachine]
		private IEnumerator ResetFooterCanvasSettings(int waitframe);
		public void SetHeaderFooterCanvasPlaneDistance(int distance);
		[IteratorStateMachine]
		private IEnumerator SetHeaderFooterCanvasPlaneDistanceCoroutine(int distance);
		private void SetHeaderFooterCanvasPlaneDistanceImpl(int distance);
		public BackButton SetupBackSceneButton(Canvas canvas, UnityAction prevAction);
		public void CreateTouchGuard(float duration = -1f);
		[IteratorStateMachine]
		private IEnumerator TouchGuardWaitCoroutine(float duration);
		public void RemoveAllTouchGuard();
		public void RemoveTouchGuard();
		[IteratorStateMachine]
		private IEnumerator RemoveTouchGuardWaitCoroutine();
		public TouchGuardObject CreateTouchGuardObject(string label, float duration = -1f);
		public void RemoveTouchGuardObject(TouchGuardObject touchGuardObject);
		public bool IsTouchGuard();
		public void UpdateHeaderInfo();
		public void SetBackButtonActive(bool isActive);
		public void SetBackButtonInteractable(bool interactable);
		public virtual void OnPopupOpened();
		public virtual void OnPopupClosed();
		public bool IsPopupOpened();
		public virtual void StartExitAnimation();
		[IteratorStateMachine]
		private IEnumerator ExitAnimationCoroutine();
		protected virtual void OnExitAnimationCompleted();
		public virtual void ChangePage(SceneNameDefine.PageName pageName, Transform parentTransform, AnimationUICanvas.AnimationPattern exitPattern = AnimationUICanvas.AnimationPattern.Pattern_1, AnimationUICanvas.AnimationPattern enterPattern = AnimationUICanvas.AnimationPattern.Pattern_1, Action<PageBase> onLoaded = null, object data = null, bool allowSamePageReload = true, bool delayEnterAnimation = true, bool deactivateLastPage = true);
		public virtual void OnBeforeLeaving();
		public virtual void OnPresentReceived();
		public virtual void OnItemUsed();
		public bool SkipCheckDateChangeForTutorial();
		public bool CheckDateChange(bool withCallEvent = false);
		protected virtual void OnDateChanged();
		public bool CheckMaintenance(bool withCallEvent = false);
		protected virtual void OnMaintenance(MaintenanceFunctionType type);
		private void OnApplicationPause(bool pauseStatus);
		protected virtual void LateUpdate();
		private void CheckForPromotedItem();
		public static void CreatePromotedIAPCommonNGPopup();
		public static void CreatePromotedIAPTutorialNGPopup();
		private void CreatePromotedIAP();
		[CompilerGenerated]
		private bool _WaitPrevSceneExit_b__40_3();
	}
}
