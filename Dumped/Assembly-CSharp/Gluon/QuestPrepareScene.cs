/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using Cute.Http;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestPrepareScene : SceneBase, ICustomMessage
	{
		// Fields
		public static int selectQuestId;
		[CompilerGenerated]
		private static QuestSupportListCellData _supportUserData_k__BackingField;
		public static bool isQuestSelectFlow;
		public Camera mainCamera;
		public Camera renderChangeMemberCamera;
		public QuestCharacterCtrl[] characterCtrls;
		private QuestPrepareData[] questPartyDatas;
		public QuestPrepareData subPartyMemberData;
		private QuestPrepareData[] clearPartyDatas;
		public static Action<Action> onFinishMapInstance;
		public bool isChagingSubMember;
		public QuestPrepareCanvas questPrepareCanvas;
		private PopupCanvas changeMemberPopupCanvas;
		private Vector3 localButtonBasePos;
		private AudioPlayback bgmPlayback;
		private PartyScene partyScene;
		private Button backButton;
		private EmptyQuestClearUnitData[] emptyUnitData;
		private bool isConnecting;
	
		// Properties
		public static QuestSupportListCellData supportUserData { [CompilerGenerated] get; [CompilerGenerated] set; }
		public QuestPrepareData[] activePartyPrepareData { get; }
		public bool isCurrentClearParty { get; set; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__30_0;
			public static Func<bool> __9__33_0;
			public static Action __9__68_1;
			public static Action __9__69_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__30_0();
			internal bool _SetupRenderBg_b__33_0();
			internal void _Tutorial_2_1_2_Coroutine_b__68_1();
			internal void _GoPartyEquipScene_b__69_0();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__30 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestPrepareScene __4__this;
			private GameObject _obj_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__30(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public QuestPrepareScene __4__this;
			public bool closedDialog;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal void _SetupRenderBg_b__1();
			internal void _SetupRenderBg_b__2();
			internal bool _SetupRenderBg_b__3();
		}
	
		[CompilerGenerated]
		private sealed class _SetupRenderBg_d__33 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestPrepareScene __4__this;
			private __c__DisplayClass33_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetupRenderBg_d__33(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitExitAnim_d__50 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestPrepareScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitExitAnim_d__50(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private struct _RequestSaveClearPartyMulti_d__55 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public int questId;
			public QuestPrepareScene __4__this;
			private TaskAwaiter<QuestGetQuestClearPartyMultiResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass68_0
		{
			// Fields
			public TutorialGuideWindowData windowData;
	
			// Constructors
			public __c__DisplayClass68_0();
	
			// Methods
			internal void _Tutorial_2_1_2_Coroutine_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_2_1_2_Coroutine_d__68 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestPrepareScene __4__this;
			private __c__DisplayClass68_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_2_1_2_Coroutine_d__68(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestPrepareScene();
		static QuestPrepareScene();
	
		// Methods
		private bool IsValidPlayFlow();
		private void Awake();
		public static void PreLoad();
		[IteratorStateMachine]
		private IEnumerator Start();
		public void ResetPartySwichClearPartyData();
		private void OnDestroy();
		[IteratorStateMachine]
		private IEnumerator SetupRenderBg();
		public void ReloadAllCharacterModels(bool isAutoSelect = false);
		public void ChangeMemberSelected(int index);
		public void ReloadClearPartyData(bool isShowEmptyPop = true);
		public void ReloadQuestPartyData();
		public void ChangeQuestPartyData(int index);
		private void QuestStartButtonPressed();
		private void PartyEditButtonPressed();
		private void BackButtonPressed();
		private void Back();
		private bool IsMainQuest();
		private void BindBackButtonForQuestSupportPage();
		private void BackButtonPressedCallback();
		private void EventBackButtonPressedCallback();
		private void EventTopBackButtonPressedCallback();
		public void OnFooterPressed(string tabName, Footer.MenuTab tabType);
		public void OnFooterLongPressed(string tabName, Footer.MenuTab tabType);
		[IteratorStateMachine]
		private IEnumerator WaitExitAnim(string tabName, Footer.MenuTab tabType);
		public void CreateSubPartyMemberData();
		public static QuestPrepareData[] CreateClearPartyData(PartySettingList[] partyData);
		private void SetLayerRecursively(Transform t, int layerId);
		public void GetClearPartyData();
		public async void RequestSaveClearPartyMulti(int questId);
		private void OnQuestGetQuestClearPartySuccess(QuestGetQuestClearPartyResponse res);
		private void OnWallGetWallClearPartySuccess(WallGetWallClearPartyResponse res);
		public void OnError(ErrorType errorType, int resultCode);
		private void GoToIngame();
		public bool HasClearPartyData();
		private new Coroutine StartCoroutine(IEnumerator coroutine);
		public override void OnBeforeLeaving();
		public override void OnPresentReceived();
		private void DestroyPartyBgManager(bool isImmediately = false);
		public void OnMessagReceived(CustomMessageType messageType, object data);
		private void ShowEmptyQuestClearUnitPopup();
		private void Tutorial_2_1_2();
		[IteratorStateMachine]
		private IEnumerator Tutorial_2_1_2_Coroutine();
		public void GoPartyEquipScene();
		private void DetachFooterCallback();
		[CompilerGenerated]
		private bool _Start_b__30_1();
		[CompilerGenerated]
		private void _QuestStartButtonPressed_b__39_0();
		[CompilerGenerated]
		private void _QuestStartButtonPressed_b__39_1();
		[CompilerGenerated]
		private void _OnError_b__58_0();
		[CompilerGenerated]
		private void _GoToIngame_b__59_0(Action onAnimationDone);
		[CompilerGenerated]
		private void _GoToIngame_b__59_1();
		[CompilerGenerated]
		private void _GoToIngame_b__59_2();
		[CompilerGenerated]
		private void _Tutorial_2_1_2_b__67_0();
		[CompilerGenerated]
		private void _GoPartyEquipScene_b__69_1();
		[CompilerGenerated]
		private void _GoPartyEquipScene_b__69_2();
	}
}
