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
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CraftTargetSelectScene : CraftEffectSceneBase
	{
		// Fields
		public static bool isShowCraftPage;
		[SerializeField]
		private Transform overlayParent;
		private CraftTargetSelectMainCanvas mainCanvas;
		private WeaponCraftDataElement craftTargetData;
		private CraftCreateResponse craftResponse;
		private bool isReloadList;
		private bool isGoToPowerup;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__8_0;
			public static UnityAction __9__14_0;
			public static UnityAction __9__19_4;
			public static UnityAction __9__28_0;
			public static UnityAction __9__29_0;
			public static UnityAction __9__34_0;
			public static UnityAction __9__36_0;
			public static Action __9__41_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__8_0();
			internal void _BackButtonPressed_b__14_0();
			internal void _OnCraftCellButtonPressed_b__19_4();
			internal void _GoNextScene_b__28_0();
			internal void _GoNextSceneByMasterId_b__29_0();
			internal void _CloseCraftEffect_b__34_0();
			internal void _OnDismantleWeaponButtonPressed_b__36_0();
			internal void _Tutorial_2_6_2_ToFort_Coroutine_b__41_0();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__8 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CraftTargetSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__8(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadCraftDataCoroutine_d__11 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CraftTargetSelectScene __4__this;
			private UIAnimationPublisher _animation_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadCraftDataCoroutine_d__11(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public CraftTargetSelectScene __4__this;
			public WeaponType type;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _TabChangeCallBack_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public CraftTargetSelectScene __4__this;
			public CraftTargetSelectCellData cellData;
	
			// Constructors
			public __c__DisplayClass19_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_1
		{
			// Fields
			public CraftStepupConfirmPopup confirmDialog;
			public __c__DisplayClass19_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass19_1();
	
			// Methods
			internal void _OnCraftCellButtonPressed_b__0();
			internal void _OnCraftCellButtonPressed_b__1();
			internal void _OnCraftCellButtonPressed_b__2();
			internal void _OnCraftCellButtonPressed_b__3(CraftStepupConfirmPopupBackupData backupData);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0
		{
			// Fields
			public CraftTargetSelectScene __4__this;
			public CraftTargetSelectCellData cellData;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal void _OnTreeButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public CraftTargetSelectScene __4__this;
			public CraftStepupSendData sendData;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _SendCraftData_b__0(CraftCreateResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_1
		{
			// Fields
			public bool isFirstLoaded;
			public __c__DisplayClass21_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass21_1();
	
			// Methods
			internal void _SendCraftData_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public string tabName;
			public Footer.MenuTab tabType;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _FooterButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public UnityAction nextSceneCallback;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _ChangeSceneCallback_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public CraftTargetSelectScene __4__this;
			public WeaponEvolutionListCellData cellData;
	
			// Constructors
			public __c__DisplayClass27_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_1
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass27_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass27_1();
	
			// Methods
			internal void _IconButtonPressed_b__0();
			internal void _IconButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public CraftTargetSelectScene __4__this;
			public CommonIconListCellData data;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal void _IconButtonLongPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public PointerEventHandler skipHandler;
			public CraftTargetSelectScene __4__this;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal void _AfterResultAction_b__0();
			internal void _AfterResultAction_b__1();
			internal void _AfterResultAction_b__2();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_2_6_2_Coroutine_d__39 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CraftTargetSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_2_6_2_Coroutine_d__39(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_2_6_2_ToFort_Coroutine_d__41 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CraftTargetSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_2_6_2_ToFort_Coroutine_d__41(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public CraftTargetSelectScene();
		static CraftTargetSelectScene();
	
		// Methods
		private void Awake();
		[IteratorStateMachine]
		private IEnumerator Start();
		private void OnPrevSceneExitDone();
		private void OnInitReady();
		[IteratorStateMachine]
		private IEnumerator LoadCraftDataCoroutine();
		private void OnEnterScene();
		private void OnDestroy();
		public void BackButtonPressed();
		public override void OnPresentReceived();
		private void LoadCraftList(WeaponType type);
		private void LoadEvolutionList(bool isShowAll);
		private void TabChangeCallBack(WeaponType type);
		private void OnCraftCellButtonPressed(CraftTargetSelectCellData cellData, bool isUseBackup = false);
		private void OnTreeButtonPressed(CraftTargetSelectCellData cellData);
		private void SendCraftData(CraftStepupSendData sendData);
		private void FooterButtonPressed(string tabName, Footer.MenuTab tabType);
		private void ChangeSceneCallback(UnityAction nextSceneCallback);
		private void TabSelected(int index);
		private ulong[] CreateDataIdList();
		public static bool IsEnableGradeup(WeaponCraftDataElement masterCraftData, int weaponId);
		private void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void GoNextScene(ulong baseKeyId);
		public void GoNextSceneByMasterId(int baseMasterId);
		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		public void OnSortButtonClicked();
		protected override void SetupCraftEffectData();
		private void AfterResultAction();
		protected override void CloseCraftEffect();
		protected override bool PlayNextEffect(bool isBackKey = false);
		private void OnDismantleWeaponButtonPressed();
		private void SetupTutorial();
		private void Tutorial_2_6_2();
		[IteratorStateMachine]
		private IEnumerator Tutorial_2_6_2_Coroutine();
		private void Tutorial_2_6_2_ToFort();
		[IteratorStateMachine]
		private IEnumerator Tutorial_2_6_2_ToFort_Coroutine();
		[CompilerGenerated]
		private void _Tutorial_2_6_2_b__38_0();
		[CompilerGenerated]
		private void _Tutorial_2_6_2_Coroutine_b__39_0();
		[CompilerGenerated]
		private void _Tutorial_2_6_2_ToFort_b__40_0();
	}
}
