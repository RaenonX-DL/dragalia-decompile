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
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyCharacterScene : SceneBase
	{
		// Fields
		[CompilerGenerated]
		private static string _BackSceneName_k__BackingField;
		private PartyCharacterUICanvas mainCanvas;
		private bool isOverrideOldPartyData;
		public Camera mainCamera;
		public Canvas bgCanvas;
		public QuestCharacterCtrl[] characterCtrls;
		private CommonPopup leaderCheackDialog;
		private Button backButton;
		public SelectState selectState;
		public CommonIconListCellData currentSelectedData;
		public static bool fromMatching;
		public int partyIndexfromMatching;
		private PartyCharacterListController partyListController;
		private AudioPlayback bgmPlayback;
		public static GameObject[][] tempAttributeMatchEffects;
	
		// Properties
		public static string BackSceneName { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum SelectState
		{
			None = 0,
			CharacterSelected = 1,
			IconSelected = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0
		{
			// Fields
			public UnityEngine.Object prefab;
			public bool isLoaded;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal void _Start_b__0(UnityEngine.Object mainCanvasAsset);
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__20 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyCharacterScene __4__this;
			private __c__DisplayClass20_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__20(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExit_d__25 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyCharacterScene __4__this;
			private SceneController _sceneController_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitPrevSceneExit_d__25(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0
		{
			// Fields
			public PartyCharacterScene __4__this;
			public UnityAction saveEndCallBack;
	
			// Constructors
			public __c__DisplayClass26_0();
	
			// Methods
			internal void _SavePartyData_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<ErrorType, int> __9__26_1;
			public static Action<ErrorType, int> __9__27_1;
			public static Action __9__47_0;
			public static Action __9__48_0;
			public static Action __9__50_0;
			public static Action<ErrorType, int> __9__54_5;
			public static Action<ErrorType, int> __9__54_3;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _SavePartyData_b__26_1(ErrorType type, int resultCode);
			internal void _SavePartyNo_b__27_1(ErrorType error, int resultCode);
			internal void _GoMatchingScene_b__47_0();
			internal void _GoPartyTopScene_b__48_0();
			internal void _OnEquipChangeButtonPressed_b__50_0();
			internal void _CheckChangeParty_b__54_5(ErrorType type, int resultCode);
			internal void _CheckChangeParty_b__54_3(ErrorType type, int resultCode);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public UnityAction saveEndCallBack;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal void _SavePartyNo_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _LoadBaseListData_d__29 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyCharacterScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadBaseListData_d__29(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_0
		{
			// Fields
			public bool isLimitedElementalQuest;
			public PartyCharacterScene __4__this;
	
			// Constructors
			public __c__DisplayClass46_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_1
		{
			// Fields
			public CommonPopup popup;
			public int tempSortingOrder;
			public __c__DisplayClass46_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass46_1();
	
			// Methods
			internal void _OnBackButtonPressed_b__0();
			internal void _OnBackButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass52_0
		{
			// Fields
			public PartyCharacterScene __4__this;
			public int index;
	
			// Constructors
			public __c__DisplayClass52_0();
	
			// Methods
			internal void _PagerSelectCallBack_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_0
		{
			// Fields
			public PartyCharacterScene __4__this;
			public Action changeSuccessAction;
			public Action __9__4;
	
			// Constructors
			public __c__DisplayClass54_0();
	
			// Methods
			internal void _CheckChangeParty_b__0();
			internal void _CheckChangeParty_b__1();
			internal void _CheckChangeParty_b__4();
			internal void _CheckChangeParty_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass55_0
		{
			// Fields
			public PartyCharacterScene __4__this;
			public string tabName;
			public Footer.MenuTab tabType;
	
			// Constructors
			public __c__DisplayClass55_0();
	
			// Methods
			internal void _FooterButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass56_0
		{
			// Fields
			public PartyCharacterScene __4__this;
			public string tabName;
			public Footer.MenuTab tabType;
	
			// Constructors
			public __c__DisplayClass56_0();
	
			// Methods
			internal void _FooterButtonLongPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass57_0
		{
			// Fields
			public PartyCharacterScene __4__this;
			public string tabName;
			public Footer.MenuTab tabType;
			public bool fromMatching;
			public bool isLongPressed;
			public UnityAction __9__4;
	
			// Constructors
			public __c__DisplayClass57_0();
	
			// Methods
			internal void _PartyEditPopup_b__1();
			internal void _PartyEditPopup_b__4();
			internal void _PartyEditPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass57_1
		{
			// Fields
			public CommonPopup popup;
			public Action onOk;
	
			// Constructors
			public __c__DisplayClass57_1();
	
			// Methods
			internal void _PartyEditPopup_b__2();
			internal void _PartyEditPopup_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass60_0
		{
			// Fields
			public DuplicateCharaDialog duplicateCharaDialog;
			public int duplicateCharaId;
			public PartyCharacterScene __4__this;
			public int charaId;
			public UnityAction disableSelection;
	
			// Constructors
			public __c__DisplayClass60_0();
	
			// Methods
			internal void _ShowDuplicateCharaDialog_b__0();
			internal void _ShowDuplicateCharaDialog_b__1();
		}
	
		// Constructors
		public PartyCharacterScene();
		static PartyCharacterScene();
	
		// Methods
		private void OnEnable();
		[IteratorStateMachine]
		private IEnumerator Start();
		private void OnDestroy();
		public override void OnPresentReceived();
		public void ReloadCharacterModel(int index, bool isPlayVoice, PartyReloadCharaAnimationType animationType = PartyReloadCharaAnimationType.LandAnimationNotDelay);
		public void RemoveCharacterModel(int index);
		[IteratorStateMachine]
		private new IEnumerator WaitPrevSceneExit();
		public void SavePartyData(UnityAction saveEndCallBack);
		private void SavePartyNo(UnityAction saveEndCallBack);
		public void InitIconList();
		[IteratorStateMachine]
		private IEnumerator LoadBaseListData();
		public void OnSortButtonClicked();
		public void OnSortApplied();
		private ulong[] CreateDataIdList();
		private void PutOutCharacter(int charaId, int charaIndexInParty);
		private void DisableCharaSelect();
		private void DisableIconSelect();
		private void DisablePartyAndIconSelect();
		public void OnCharacterButtonPressed(int index);
		public void OnCharacterButtonLongPressed(int index);
		private int GetIndexOfCharacterInParty(int index, int charaId);
		private void SwapCharacterInParty(int index1, int index2);
		private void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void OutButtonPressed();
		public void ChangePartyChara(bool isAutoSelect = false);
		public void SetPartyListController(PartyCharacterListController controller);
		public void OnBackButtonPressed();
		private void GoMatchingScene();
		private void GoPartyTopScene();
		private void GoBackScene();
		public void OnEquipChangeButtonPressed();
		public void ChagePartyCallBack();
		public void PagerSelectCallBack(int index);
		private void ChangePartyCallBack(Action changeSuccessAction);
		public void CheckChangeParty(Action changeSuccessAction);
		private void FooterButtonPressed(string tabName, Footer.MenuTab tabType);
		private void FooterButtonLongPressed(string tabName, Footer.MenuTab tabType);
		private void PartyEditPopup(string tabName, Footer.MenuTab tabType, bool fromMatching, bool isLongPressed);
		private void GoAnotherScene(string tabName, Footer.MenuTab tabType, bool fromMatching, bool isLongPressed);
		private int CheckDuplicatePartyChara(int charaId);
		private void ShowDuplicateCharaDialog(int charaId, int duplicateCharaId, int duplicateCharaRarity, UnityAction disableSelection);
		public void ChangeParty(int index);
		private void DetachFooterCallback();
		private void ReplaceAttributeMatchEffects(PartyCharacterUIStatus[] partyStatus);
		[CompilerGenerated]
		private void _GoMatchingScene_b__47_1();
		[CompilerGenerated]
		private void _GoMatchingScene_b__47_2();
		[CompilerGenerated]
		private void _GoPartyTopScene_b__48_1();
		[CompilerGenerated]
		private void _GoPartyTopScene_b__48_2();
		[CompilerGenerated]
		private void _OnEquipChangeButtonPressed_b__50_1();
		[CompilerGenerated]
		private void _OnEquipChangeButtonPressed_b__50_2();
		[CompilerGenerated]
		private void _ChagePartyCallBack_b__51_0();
	}
}
