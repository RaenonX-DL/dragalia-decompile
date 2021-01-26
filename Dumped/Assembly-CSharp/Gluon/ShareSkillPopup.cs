/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using UniRx.Async;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShareSkillPopup : PopupBase
	{
		// Fields
		[HideInInspector]
		public SceneBase scene;
		[SerializeField]
		private CommonIconListBase equipUnitListBase;
		[SerializeField]
		private EquipUnitListController equipUnitListController;
		[SerializeField]
		private TabBase typeTab;
		[SerializeField]
		private Transform commonIconTrans;
		[SerializeField]
		private PointerEventHandler skillIconButton;
		[SerializeField]
		private UnityEngine.UI.Text shareSkillName;
		[SerializeField]
		private UnityEngine.UI.Text shareSkillDetail;
		[SerializeField]
		private UnityEngine.UI.Text equipTitle;
		[SerializeField]
		private UnityEngine.UI.Text noShareSkillName;
		[SerializeField]
		private GameObject shareSkillNode;
		[SerializeField]
		private Button okButton;
		[SerializeField]
		private UnityEngine.UI.Text equipSkillCost;
		private CommonSkillIcon commonSkillIcon;
		private UnityAction onReload;
		private int cacheActiveSkill3CharaId;
		private int cacheActiveSkill4CharaId;
		private CommonSortModel.Preset cachePreset;
		private GiftType cacheGiftType;
		private ElementalType cacheElementlType;
		private Func<CommonListCustomSortData, CommonListCustomSortData> customSortAction;
		private bool isPlayingEditSkillTutorial;
		private SkillListCellData skillData;
		private TableViewCell<CommonIconListCellData> unlockEffectTargetCell;
	
		// Nested types
		[CompilerGenerated]
		private struct _EquipListReload_d__33 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public ShareSkillPopup __4__this;
			private TouchGuardObject _touchObject_5__2;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_0
		{
			// Fields
			public ShareSkillPopup __4__this;
			public TableViewCell<CommonIconListCellData> cell;
			public SkillListCellData skillData;
	
			// Constructors
			public __c__DisplayClass40_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_1
		{
			// Fields
			public ReleaseEquipSkillPopup releasePopup;
			public __c__DisplayClass40_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass40_1();
	
			// Methods
			internal void _OnSkillCellPressed_b__0();
			internal void _OnSkillCellPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_2
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass40_2();
	
			// Methods
			internal void _OnSkillCellPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_3
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass40_3();
	
			// Methods
			internal void _OnSkillCellPressed_b__3();
		}
	
		[CompilerGenerated]
		private struct _SendEditSkillUnlockData_d__41 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public int unlockCharaId;
			public ShareSkillPopup __4__this;
			private TaskAwaiter<CharaUnlockEditSkillResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass42_0
		{
			// Fields
			public ShareSkillPopup __4__this;
			public TouchGuardObject touchObject;
	
			// Constructors
			public __c__DisplayClass42_0();
	
			// Methods
			internal void _PlayReleaseEditSkillUnlockEffect_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass49_0
		{
			// Fields
			public UnityAction saveEndCallBack;
			public ShareSkillPopup __4__this;
	
			// Constructors
			public __c__DisplayClass49_0();
	
			// Methods
			internal void _SavePartyData_b__0();
			internal void _SavePartyData_b__1(ErrorType type, int resultCode);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass49_1
		{
			// Fields
			public ErrorType type;
			public int resultCode;
			public Action errorAction;
			public __c__DisplayClass49_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass49_1();
	
			// Methods
			internal void _SavePartyData_b__2();
			internal void _SavePartyData_b__3();
		}
	
		// Constructors
		public ShareSkillPopup();
	
		// Methods
		public static ShareSkillPopup Create(SceneBase scene, UnityAction reload);
		protected override void Start();
		private void InitActiveTab(int activeIndex);
		private void OnSelectedTypeTab(int typeIndex);
		private void SetTabMode(PartyModel.EquipMode nextMode);
		public void SetEquipListOutButton(PartyModel.EquipMode equipMode);
		private void InitIconList();
		public void LoadEquipListData();
		public CommonListCustomSortData SkillListSort(CommonListCustomSortData data);
		private async void EquipListReload();
		public void OnSortButtonClicked();
		private ulong[] CreateDataIdList();
		public void OnSelectedSkillIconPressed();
		private void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void outButtonPressed();
		public void OnSkillCellPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private async void SendEditSkillUnlockData(int unlockCharaId);
		private void PlayReleaseEditSkillUnlockEffect();
		private void SelectEquipUnit(CommonEquipIconCellData equipData);
		private void SelectEquipIconCellData(ulong keyId, CommonEquipIconCellData equipData, bool hasOutButtonSelectState);
		private void SetTopUI();
		public void SetSkillCost();
		public void OnOkButton();
		public void OnCancelButton();
		public void SavePartyData(UnityAction saveEndCallBack);
		public void DisableAllButton();
		public void SetSkill4TabEnable();
		protected override void OnDestroy();
		[CompilerGenerated]
		private CommonListCustomSortData _LoadEquipListData_b__31_0(CommonListCustomSortData data);
		[CompilerGenerated]
		private void _EquipListReload_b__33_0();
		[CompilerGenerated]
		private void _OnOkButton_b__47_0();
		[CompilerGenerated]
		private void _OnOkButton_b__47_2();
		[CompilerGenerated]
		private void _OnOkButton_b__47_1();
	}
}
