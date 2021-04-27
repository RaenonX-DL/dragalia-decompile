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

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
		private static int partyIndexFromMatching;
		private static bool isClearPartyFromMatching;
		private int backButtonSortingOrder;
		private PartyCharacterListController partyListController;
		public AudioPlayback bgmPlayback;
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
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public UnityEngine.Object prefab;
			public bool isLoaded;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _Start_b__0(UnityEngine.Object mainCanvasAsset);
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__22 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyCharacterScene __4__this;
			private __c__DisplayClass22_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__22(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExit_d__27 : IEnumerator<object>
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
			public _WaitPrevSceneExit_d__27(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public PartyCharacterScene __4__this;
			public UnityAction saveEndCallBack;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _SavePartyData_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<ErrorType, int> __9__28_1;
			public static Action<ErrorType, int> __9__29_1;
			public static Action __9__50_0;
			public static Action __9__51_0;
			public static Action __9__53_0;
			public static Action<ErrorType, int> __9__57_5;
			public static Action<ErrorType, int> __9__57_3;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _SavePartyData_b__28_1(ErrorType type, int resultCode);
			internal void _SavePartyNo_b__29_1(ErrorType error, int resultCode);
			internal void _GoMatchingScene_b__50_0();
			internal void _GoPartyTopScene_b__51_0();
			internal void _OnEquipChangeButtonPressed_b__53_0();
			internal void _CheckChangeParty_b__57_5(ErrorType type, int resultCode);
			internal void _CheckChangeParty_b__57_3(ErrorType type, int resultCode);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public PartyCharacterScene __4__this;
			public UnityAction saveEndCallBack;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _SavePartyNo_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _LoadBaseListData_d__32 : IEnumerator<object>
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
			public _LoadBaseListData_d__32(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass49_0
		{
			// Fields
			public PartyCharacterScene __4__this;
			public bool isLimitedElementalQuest;
			public bool isLimitedWeaponTypeQuest;
	
			// Constructors
			public __c__DisplayClass49_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass49_1
		{
			// Fields
			public QuestLimitedConfirmPopup popup;
			public __c__DisplayClass49_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass49_1();
	
			// Methods
			internal void _OnBackButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass49_2
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass49_0 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass49_2();
	
			// Methods
			internal void _OnBackButtonPressed_b__1();
			internal void _OnBackButtonPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass55_0
		{
			// Fields
			public PartyCharacterScene __4__this;
			public int index;
	
			// Constructors
			public __c__DisplayClass55_0();
	
			// Methods
			internal void _PagerSelectCallBack_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass57_0
		{
			// Fields
			public PartyCharacterScene __4__this;
			public Action changeSuccessAction;
			public Action __9__4;
	
			// Constructors
			public __c__DisplayClass57_0();
	
			// Methods
			internal void _CheckChangeParty_b__0();
			internal void _CheckChangeParty_b__1();
			internal void _CheckChangeParty_b__4();
			internal void _CheckChangeParty_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass58_0
		{
			// Fields
			public PartyCharacterScene __4__this;
			public string tabName;
			public Footer.MenuTab tabType;
	
			// Constructors
			public __c__DisplayClass58_0();
	
			// Methods
			internal void _FooterButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass59_0
		{
			// Fields
			public PartyCharacterScene __4__this;
			public string tabName;
			public Footer.MenuTab tabType;
	
			// Constructors
			public __c__DisplayClass59_0();
	
			// Methods
			internal void _FooterButtonLongPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass60_0
		{
			// Fields
			public PartyCharacterScene __4__this;
			public string tabName;
			public Footer.MenuTab tabType;
			public bool fromMatching;
			public bool isLongPressed;
			public UnityAction __9__4;
	
			// Constructors
			public __c__DisplayClass60_0();
	
			// Methods
			internal void _PartyEditPopup_b__1();
			internal void _PartyEditPopup_b__4();
			internal void _PartyEditPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass60_1
		{
			// Fields
			public CommonPopup popup;
			public Action onOk;
	
			// Constructors
			public __c__DisplayClass60_1();
	
			// Methods
			internal void _PartyEditPopup_b__2();
			internal void _PartyEditPopup_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass64_0
		{
			// Fields
			public DuplicateCharaDialog duplicateCharaDialog;
			public int duplicateCharaId;
			public PartyCharacterScene __4__this;
			public int charaId;
			public UnityAction disableSelection;
	
			// Constructors
			public __c__DisplayClass64_0();
	
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
		private void SavePartySwichIndex();
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
		public void CreatePartySettingTempararyCharaErrerPopupAndReload();
		private void GoAnotherScene(string tabName, Footer.MenuTab tabType, bool fromMatching, bool isLongPressed);
		private int CheckDuplicatePartyChara(int charaId);
		private void ShowDuplicateCharaDialog(int charaId, int duplicateCharaId, int duplicateCharaRarity, UnityAction disableSelection);
		public void ChangeParty(int index);
		private void DetachFooterCallback();
		private void ReplaceAttributeMatchEffects(PartyCharacterUIStatus[] partyStatus);
		[CompilerGenerated]
		private void _GoMatchingScene_b__50_1();
		[CompilerGenerated]
		private void _GoMatchingScene_b__50_2();
		[CompilerGenerated]
		private void _GoPartyTopScene_b__51_1();
		[CompilerGenerated]
		private void _GoPartyTopScene_b__51_2();
		[CompilerGenerated]
		private void _OnEquipChangeButtonPressed_b__53_1();
		[CompilerGenerated]
		private void _OnEquipChangeButtonPressed_b__53_2();
		[CompilerGenerated]
		private void _ChagePartyCallBack_b__54_0();
	}
}
