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
using FLATOUT.Main;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyEquipScene : SceneBase
	{
		// Fields
		public PartyEquipUICanvas mainCanvas;
		public const string prefabDir = "Prefabs/OutGame/Party/PartyEquip/";
		public EquipUnitListController equipUnitListController;
		public Camera mainCamera;
		private AudioPlayback bgmPlayback;
		private Button backButton;
		private GameObject attributeMatch;
		private Coroutine attributeMatchUpdateParentGroupAlphaCoroutine;
		private const string attributeMatchPathBase = "Prefabs/OutGame/Party/Flash/pf_AttributeMatch";
		private const string attributeMatchReplaceTextMaterialPathBase = "Images/OutGame/Party/AttributeMatch/AttributeMatch";
		private TableViewCell<CommonIconListCellData> unlockEffectTargetCell;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExit_d__15 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyEquipScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitPrevSceneExit_d__15(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public PartySceneState state;
			public PartyEquipScene __4__this;
			public UnityAction __9__2;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _GoPartyScene_b__1();
			internal void _GoPartyScene_b__2();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__17_0;
			public static UnityAction __9__18_1;
			public static Func<CommonListCustomSortData, CommonListCustomSortData> __9__21_0;
			public static Action<ErrorType, int> __9__35_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _GoPartyScene_b__17_0();
			internal void _OnBackButtonPressed_b__18_1();
			internal CommonListCustomSortData _LoadEquipListData_b__21_0(CommonListCustomSortData data);
			internal void _SendMainPartyAndGoAnotherScene_b__35_1(ErrorType error, int resultCode);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public UnityAction saveEndCallBack;
			public PartyEquipScene __4__this;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _SavePartyData_b__0();
			internal void _SavePartyData_b__1(ErrorType type, int resultCode);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_1
		{
			// Fields
			public ErrorType type;
			public int resultCode;
			public Action errorAction;
			public __c__DisplayClass19_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass19_1();
	
			// Methods
			internal void _SavePartyData_b__2();
			internal void _SavePartyData_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public ulong equippedId;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal bool _InsertActiveEquipmentToFilteredList_b__0(ulong id);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public PartyEquipScene __4__this;
			public CommonEquipIconCellData equipData;
	
			// Constructors
			public __c__DisplayClass28_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_1
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass28_1();
	
			// Methods
			internal void _IconButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_2
		{
			// Fields
			public PartyEquipOverPopup popup;
			public __c__DisplayClass28_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass28_2();
	
			// Methods
			internal void _IconButtonPressed_b__1();
			internal void _IconButtonPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_3
		{
			// Fields
			public AlreadyEquipedDialog alreadyEquipedDialog;
			public int equipCharaId;
			public __c__DisplayClass28_0 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass28_3();
	
			// Methods
			internal void _IconButtonPressed_b__3();
			internal void _IconButtonPressed_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public PartyEquipScene __4__this;
			public CommonEquipIconCellData equipData;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _IconButtonLongPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal void _outButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0
		{
			// Fields
			public PartyEquipScene __4__this;
			public TableViewCell<CommonIconListCellData> cell;
			public SkillListCellData skillData;
	
			// Constructors
			public __c__DisplayClass31_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_1
		{
			// Fields
			public ReleaseEquipSkillPopup releasePopup;
			public __c__DisplayClass31_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass31_1();
	
			// Methods
			internal void _OnSkillCellPressed_b__0();
			internal void _OnSkillCellPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_2
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass31_2();
	
			// Methods
			internal void _OnSkillCellPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_3
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass31_3();
	
			// Methods
			internal void _OnSkillCellPressed_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0
		{
			// Fields
			public PartyEquipScene __4__this;
			public string tabName;
			public Footer.MenuTab tabType;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal void _FooterButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public PartyEquipScene __4__this;
			public string tabName;
			public Footer.MenuTab tabType;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal void _FooterButtonLongPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0
		{
			// Fields
			public PartyEquipScene __4__this;
			public string tabName;
			public Footer.MenuTab tabType;
			public bool fromMatching;
			public bool isLongPressed;
	
			// Constructors
			public __c__DisplayClass34_0();
	
			// Methods
			internal void _PartyEditPopup_b__1();
			internal void _PartyEditPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_1
		{
			// Fields
			public CommonPopup popup;
			public Action onOk;
			public __c__DisplayClass34_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass34_1();
	
			// Methods
			internal void _PartyEditPopup_b__2();
			internal void _PartyEditPopup_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_0
		{
			// Fields
			public PartyEquipScene __4__this;
			public string tabName;
			public Footer.MenuTab tabType;
			public bool fromMatching;
			public bool isLongPressed;
	
			// Constructors
			public __c__DisplayClass35_0();
	
			// Methods
			internal void _SendMainPartyAndGoAnotherScene_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass38_0();
	
			// Methods
			internal void _SelectEquipUnit_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_0
		{
			// Fields
			public FlPlane flPlane;
			public PartyEquipScene __4__this;
	
			// Constructors
			public __c__DisplayClass44_0();
	
			// Methods
			internal bool _UpdateAttributeMatchParentGroupAlpha_b__0();
			internal bool _UpdateAttributeMatchParentGroupAlpha_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _UpdateAttributeMatchParentGroupAlpha_d__44 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FlPlane flPlane;
			public PartyEquipScene __4__this;
			private __c__DisplayClass44_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UpdateAttributeMatchParentGroupAlpha_d__44(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private struct _SendEditSkillUnlockData_d__49 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public int unlockCharaId;
			public PartyEquipScene __4__this;
			private TaskAwaiter<CharaUnlockEditSkillResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass50_0
		{
			// Fields
			public PartyEquipScene __4__this;
			public TouchGuardObject touchObject;
	
			// Constructors
			public __c__DisplayClass50_0();
	
			// Methods
			internal void _PlayReleaseEditSkillUnlockEffect_b__0();
		}
	
		// Constructors
		public PartyEquipScene();
	
		// Methods
		private void OnEnable();
		private void Start();
		private void OnDestroy();
		public override void OnPresentReceived();
		[IteratorStateMachine]
		private new IEnumerator WaitPrevSceneExit();
		private void SetupTutorial();
		private void GoPartyScene(PartySceneState state);
		public void OnBackButtonPressed();
		public void SavePartyData(UnityAction saveEndCallBack);
		private void InitIconList();
		public void LoadEquipListData();
		private List<ulong> InsertActiveEquipmentToFilteredList(List<ulong> filteredList);
		private GiftType GetEquipGiftType();
		public void OnSortButtonClicked();
		private ulong[] CreateDataIdList();
		private string GetEquipChangeAlertTitleString();
		private string GetEquipAlreadyEquipMessage();
		private void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void outButtonPressed();
		public void OnSkillCellPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void FooterButtonPressed(string tabName, Footer.MenuTab tabType);
		private void FooterButtonLongPressed(string tabName, Footer.MenuTab tabType);
		private void PartyEditPopup(string tabName, Footer.MenuTab tabType, bool fromMatching, bool isLongPressed);
		private void SendMainPartyAndGoAnotherScene(string tabName, Footer.MenuTab tabType, bool fromMatching, bool isLongPressed);
		private void GoAnotherScene(string tabName, Footer.MenuTab tabType, bool fromMatching, bool isLongPressed);
		private void SelectEquipIconCellData(ulong keyId, CommonEquipIconCellData equipData, bool hasOutButtonSelectState);
		private void SelectEquipUnit(CommonEquipIconCellData equipData);
		private void RefreshCrestState(PartySettingList userCharaData);
		private void RemoveEquipUnitByCharaId(int charaId, ulong keyId);
		public void ReloadWeaponModel();
		private void DetachFooterCallback();
		private void CreateAttributeMatch(ElementalType type);
		[IteratorStateMachine]
		private IEnumerator UpdateAttributeMatchParentGroupAlpha(FlPlane flPlane);
		public static string GetAttributePathAdderForText(ElementalType element);
		public void SetAttributeMatch(AutoPartyConfigData selectData);
		private void SetAttributeMatch(CommonEquipIconCellData equipData);
		public CommonListCustomSortData SkillListSort(CommonListCustomSortData data);
		private async void SendEditSkillUnlockData(int unlockCharaId);
		private void PlayReleaseEditSkillUnlockEffect();
		[CompilerGenerated]
		private void _Start_b__12_0(UnityEngine.Object mainCanvasAsset);
		[CompilerGenerated]
		private void _OnBackButtonPressed_b__18_0();
		[CompilerGenerated]
		private void _OnBackButtonPressed_b__18_2();
		[CompilerGenerated]
		private void _OnSortButtonClicked_b__24_0();
	}
}
